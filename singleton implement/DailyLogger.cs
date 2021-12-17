using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using EasySave.Views.Log;

namespace EasySave.Models.Log
{
    /// <summary>
    /// DailyLogger is a static class that records the progress state of daily backups.
    /// See the project docs to understand what it does and why.
    /// </summary>
    internal sealed class DailyLogger
    {
        private static string _path = System.IO.Path.Combine(
            Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"),
            @"ProSoft\",
            @"EasySave\",
            @"Logs\",
            "Daily.json"
        );

        /// <summary>
        /// This is the actual logger.
        /// It's Lazy, so it's not created until it's needed.
        /// </summary>
        private static readonly Lazy<DailyLogger> lazy = new Lazy<DailyLogger>(() => new DailyLogger());
        public static DailyLogger Instance { get { return lazy.Value; } }

        /// <summary>
        /// This is the constructor of the ProgressLogger class.
        /// </summary>
        private DailyLogger()
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
        public void Log(Backup.FileBackup b)
        {
            List<Backup.FileBackup> existing = null;
            {
                using var fr = new StreamReader(_path);
                existing = JsonSerializer.Deserialize<List<Backup.FileBackup>>(fr.ReadToEnd());
            }
            existing.Add(b);

            using var fw = new StreamWriter(_path);
            var serialized = JsonSerializer.Serialize(
                existing,
                new() { WriteIndented = true, IgnoreNullValues = true }
            );

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
                var serialized = JsonSerializer.Serialize(
                    new List<Backup.FileBackup>(),
                    new() { WriteIndented = true, IgnoreNullValues = true });

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
}