   M S B A M L   `   `   `  ����G  CWpfAppProjet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfAppProjetWpfAppProjet  5   	       WpfAppProjet.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfAppProjet     5   	     � Title$  EasySave��5   	   $	��450��6   $	��800��6'    � Icon$ 	/icon.png��63   ���#F5E2C8.��5	      �� ���	#FFF5E2C8.@�5
   
   �� -   5         ��Name$
 tab1��5
      $��
Save Setup��6    $��-2,-2,-59,-20q�64   ���	#FFD88373���#18206F.��5      � ���#F5E2C8 � ColumnDefinitions 5      �� 5      $	��81* �6'   �� 5      $
��185* �6'   �� 5      $
��376* �6'   �� 5      $
��152* �6'   .+�5      �� -   5         ��Name$ create_button��5      $��Create��60   $
��Left=�6A   $��
337,73,0,0q�6\   $	��Top=�6p   $��48��6�   $	��158��6�   $��2��6�   ���#17255A
���  ��$��2��6�   �� 5      -   5        $ btnOpenFile_s��5      $��Source��6K   $��37,73,49,266q�6\   $��2��6r   
���p�
���  ��6�   �� 5      -   5         ��Name$ txtEditor_source��5      $��16,160,28,202q�64   ${�False��6K   
����iA�$��2��6t   �� 5      -   5        $ btnOpenFile_d��5      $��Destination��6I   $��50,73,116,266q�6_   $��2��6v    J� RenderTransformOrigin$ 0.445,0.505&�6�   ���#17255A
���  ��6�   �� 5      -   5        $ txtEditor_dest��5      $��22,160,87,202q�62   ${�False��6I   $��2��6[   
����iA�6k   �� 5      $��	©ProSoft��6   $
��Left=�6+   $��25��6F   $��
10,353,0,0q�6R   $	��Top=�6f   $��93��6~   $��2��6�   �� 5      -   5        $��3��5      $
��Left=�6)   $��
11,299,0,0q�6D   $	��Top=�6X   $��79��6p   $	��108��6|   ��5      �� 5       �� ImageSource$ /ProSoft.png��6%   6B   5      �� 5      -   5        $
��Miss��5      $��2��6$   $
��Left=�64   $	��152��6O   $��
87,219,0,0q�6\   $	��Top=�6p   $	��151��6�   $��	/miss.png��6�   $y�Hidden=�6�   �� 5      $��1��6   $
��Left=�6(   $��40��6C   $��	26,28,0,0q�6O   $	��Top=�6b   $��44��6z   $��/source.png��6�   �� 5      $��2��6   $
��Left=�6(   $��40��6C   $��
136,28,0,0q�6O   $	��Top=�6c   $��40��6{   $��/target.png��6�   �� 5       $��3��6   $
��Left=�6(   $��46��6C   $��	17,22,0,0q�6O   $	��Top=�6b   $��48��6z   $��/create2.png��6�   5!      5"      �� 5$   
   -	   5        $
 Tab2��5$      $��Save Worker��6    ���	#FFD88373���#18206F$��58,-2,-136,-19q�6a   ${�False��6�   .��5%      � ���#F5E2C8 5&      �� 5'      $	��69* �6'   �� 5(      $
��269* �6'   �� 5)      $	��53* �6'   �� 5*      $
��403* �6'   .+�5-      �� -
   5         ��Name$ Usave_placeholder��5-      $��Unique Save
��63   $
��Left=�6S   $��
155,56,0,0q�6n   $	��Top=�6�   $
��Bold"�6�   $��18(�6�   $��3��6�   ���#BD1E1E6�   �� 5.      -   5        $ Ssave_placeholder��5.      $��Sequential save
��63   $
��Left=�6W   $��149,211,0,0q�6r   $	��Top=�6�   $
��Bold"�6�   $��18(�6�   $��3��6�   ���#BD1E1E6�   �� 5/      -   5        $ UPlay��5/      $��Start��6(   $
��Left=�68   $��
83,114,0,0q�6S   $	��Top=�6g   $��46��6   $��72��6�   $��3��6�   ���#18206F
���  ��6�   �� 50      -   5        $ UPause��50      $��Pause��6)   $
��Left=�69   $��183,114,0,0q�6T   $	��Top=�6i   $��46��6�   $��72��6�   $��3��6�   ���#18206F
���  ��6�   �� 51      -   5        $ USTop��51      $
��Stop��6(   $
��Left=�67   $��285,114,0,0q�6R   $	��Top=�6g   $��46��6   $��72��6�   $��3��6�   ���#18206F
���  ��6�   �� 52      -   5        $ SPlay��52      $��Start��6(   $
��Left=�68   $��
83,274,0,0q�6S   $	��Top=�6g   $��46��6   $��72��6�   $��3��6�   ���#18206F
���  ��6�   �� 53      -   5        $ SPause��53      $��Pause��6)   $
��Left=�69   $��184,274,0,0q�6T   $	��Top=�6i   $��46��6�   $��72��6�   $��3��6�   ���#18206F
���  ��6�   �� 54      -   5        $ SStop��54      $
��Stop��6(   $
��Left=�67   $��285,274,0,0q�6R   $	��Top=�6g   $��46��6   $��72��6�   $��3��6�   ���#18206F
���  ��6�   &   System.Windows.Controls.DataGrid  56      -   5        	  Name$	 SaveGrid��56      $��10,27,374,10q�6-   
   CanUserAddRows$

 True��6C      SelectionUnit$ FullRow=�6�   $��4��6�   ���#18206F���#BD1E1E��6Y   �� *Save+ �� SelectedItem 6v   ��  �� Path$ Saves� �� Mode$ TwoWay=�   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      -   5        	Save_Name��,  &System.Windows.Controls.DataGridColumn   Header$ 	Save_Name��58   @      
IsReadOnly$
 True��6S      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   �� $ 	Save_Name�6�     59      -   5        
Source��$ Source��59   =   $
 True��6M   $	 100 6�    6_   �� $ Save_Src�6�     5:      -   5        Destination��$ Destination��5:   B   $
 True��6W   $	 100 6�    6j   �� $ 	Save_Dest�6�   5<      �� 5=      $��	©ProSoft��6   $
��Left=�6+   $��25��6F   $��321,359,0,0q�6R   $	��Top=�6g   $��69��6   $��3��6�   5?      5@      �� 5A   
   -   5        $
 tab3��5A      $��Settings��6    $��135,-2,-213,-19q�62   ���	#FFD88373���#18206F.��5B      � ���#F5E2C8 5C      �� 5D      $	��37* �6'   �� 5E      $
��360* �6'   .+�5H      �� -   5        $ Language_placeholder��5H      $��Language��66   $��1��6I   $
��Left=�6Y   $��	64,36,0,0q�6t   $	��Top=�6�   $
��Bold"�6�   $��18(�6�   ���	#FFBD1E1E6�   �� 5I      -   5        $ FR��5I      $��French��6%   $��1��66   $
��Left=�6F   $��	0,100,0,0q�6a   $	��Top=�6t   $��46��6�   $��72��6�   $��0,0,0,0q�6�   ��5J      �� 5K      $ /france.png��6%   6A   5M      �� 5N      -   5        $ EN��5N      $��English��6%   $��1��67   $
��Left=�6G   $��141,100,0,0q�6b   $	��Top=�6w   $��46��6�   $��72��6�   ${�False��6�   $��0,0,0,0q�6�   ��5O      �� 5P      $ /english.png��6%   6B   5R      �� 5S      -   5         ��Name$ Encrypt��5S      $��Crypted��6,   $��1��6>   $
��Left=�6N   $��
10,221,0,0q�6i   $	��Top=�6}    d� 	IsChecked$ FalseY�6�   ���	#FFF5E2C8���#BD1E1E6�   �� 5T      -   5         ��Name$ ListBox��5T      $��1��6+   $��273,100,10,10q�6;   ���#18206F���#BD1E1E6g   �� 5U      -   5        $ 	Extension��5U      $��1��6-   $
��Left=�6=   $��
273,66,0,0q�6X   $�� ��6l    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��120��6�   ���#18206F
���  ��6�   �� 5V      -   5        $	 add��5V      $	��Add��6&   $��1��64   $
��Left=�6D   $��
414,66,0,0q�6_   $	��Top=�6s   ���#17255A
���  ��$��37��6�   �� 5W      -   5        $ Select��5W      $��Select��6)   $��1��6:   $
��Left=�6J   $��
472,66,0,0q�6e   $	��Top=�6y   $ 0.5,0.5&�6�   ���#17255A
���  ��$��53��6�   �� 5X      -   5        $ ServerConnect��5X      $��Server Connect��60   $��2��6I   $
��Left=�6]   $��25��6x   $��
20,309,0,0q�6�   $	��Top=�6�   $��95��6�   ���#17255A
���  ��6�   �� 5Y      -    5        $ ServerDisconnect��5Y      $��Server Disconnect��63   $��1��6O   $
��Left=�6_   $��
98,309,0,0q�6z   $	��Top=�6�   ���#17255A
���  ��$��25��6�   $	��115��6�   �� 5Z      $��	©ProSoft��6   $
��Left=�6+   $��25��6F   $��
10,355,0,0q�6R   $	��Top=�6f   $��93��6~   $��2��6�   �� 5[      $
��Left=�6   $��59��63   $��	56,23,0,0q�6?   $	��Top=�6R   $��60��6j   $��/language.png��6u   $��2��6�   �� 5\      $
��Left=�6   $��60��63   $��
24,202,0,0q�6?   $	��Top=�6S   $��50��6k   $��/crypted.png��6v   $ -3.181,0.489&�6�   5]      5^      5`      5b      