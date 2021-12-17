using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using EasySave.Views.Log;
using System.Text.Json.Serialization;

namespace EasySave.Models.Log
{
    /// <summary>
    /// ProgressLogger is a static class that records the progress of the backup.
    /// See the project docs to understand what it does and why.
    /// </summary>
    internal sealed class ProgressLogger
    {
        private static string _path = System.IO.Path.Combine(
            Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"),
            @"ProSoft\",
            @"EasySave\",
            @"Logs\",
            "Progress.json"
        );

        /// <summary>
        /// This is the actual logger.
        /// It's Lazy, so it's not created until it's needed.
        /// </summary>
        private static readonly Lazy<ProgressLogger> lazy = new Lazy<ProgressLogger>(() => new ProgressLogger());
        public static ProgressLogger Instance { get { return lazy.Value; } }

        /// <summary>
        /// This is the constructor of the ProgressLogger class.
        /// </summary>
        private ProgressLogger()
        {

            if (!System.IO.File.Exists(_path))
            {
                CreateFile();
                CreateLog();
            }
        }

        /// <summary>
        /// Actual Log function, the one that actually writes to the file.
        /// It's called mostly from Models/Backup classes.
        /// </summary>
        public void Log(ProgressLog b)
        {
            List<ProgressLog> existing = null;
            {
                using var fr = new StreamReader(_path);
                existing = JsonSerializer.Deserialize<List<ProgressLog>>(fr.ReadToEnd(), new() { WriteIndented = true, IgnoreNullValues = true });
            }
            existing.Add(b);

            using var fw = new StreamWriter(_path);
            var serialized = JsonSerializer.Serialize(existing, new() { WriteIndented = true, IgnoreNullValues = true });

            fw.Write(serialized);
        }

        /// <summary>
        /// We input a basic schema to the file.
        /// This is to be backwards compatible with the unmarshalling (desirialization) process, in case we ever change it.
        /// </summary>
        private void CreateLog()
        {
            try
            {
                using var file = File.CreateText(_path);
                var serialized = JsonSerializer.Serialize(new List<Backup.FileBackup>(), new() { WriteIndented = true, IgnoreNullValues = true });

                file.Write(serialized);
            }
            catch (Exception e)
            {
                Json.Log(e.Message);
            }
        }

        /// <summary>
        /// CreateFile creates the directories and file needed to be written to.
        /// </summary>
        private void CreateFile()
        {
            try
            {
                var dirPath = Path.GetDirectoryName(_path);
                Directory.CreateDirectory(dirPath);
            }
            catch (Exception e)
            {
                Json.Log(e.Message);
            }
        }
    }

    public struct ProgressLog
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
        public State State { get; set; }
        public ProgressState? ProgressState { get; set; }
        public string Message { get; set; }
    }

    public struct ProgressState
    {
        public int TotalFileCount { get; set; }
        public float TotalFileSize { get; set; }
        public float FileProgress { get; set; }
        public float RemainingFileSize { get; set; }
        public string FileSource { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum State
    {
        Ongoing,
        Done,
        Failed
    }
}