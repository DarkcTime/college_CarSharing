   M S B A M L   `   `   `  ����E  ACarSharing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarSharing.View.AdminCarSharing.View.Admin  5      &     CarSharing.View.Admin.ListOfCars   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CarSharing.View.Admin     5        N� Title$  
ListOfCars��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   �� 5      .+�5   
   �� $
��Bold"�6   List of cars64   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��0.7* �6#   �� 5      .+�5      �� $��Selected Car��6   
���   �$��5q�6A   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��	0 10 0 10q�6   ��62   ��  �� Path$	 VIN�6N   �� 5      -   5        $��CmbTypeOfCar��5   H    �� DisplayMemberPath$ NameType��6\   $��	0 10 0 10q�6y    �� SelectedItem 6   �� $ 
TypeOfCar1�6�   �� 5      -   5        $��
CmbCarMake��5   F   $ NameMake��6X   $��	0 10 0 10q�6u    6   �� $ CarMake1�6�   �� 5      -   5        $��CmbCarColor��5   G   $ 	NameColor��6Z   $��	0 10 0 10q�6x    6   �� $ 	CarColor1�6�   �� 5      -   5        $��CmbTypeEngine��5   I   $ 
NameEngine��6^   $��	0 10 0 10q�6}    6   �� $ TypeEngine1�6�   5      5      &   System.Windows.Controls.DataGrid  5       -   5        $��ListCars��5    `   $��1��6      
IsReadOnly .    AutoGenerateColumns .  $��5q�6U   	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6)      Header$
 Make��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5#   )   �� $ CarMake1.NameMake�6V     5$      $
 * 6)   $
 Type��63    5%   )   �� $ TypeEngine1.NameEngine�6[     5&      $
 * 6)   $ Price in minute��63    5'   )   �� $ TypeOfCar1.PriceInMinute�6]   5)      5*      � 5+   
   $��2��6    5,      �� 5-      �� 5.      �� 5/      .+�51      �� -   5        .��51   .   Save64   �� 52      -   5        $��1��52      .��6?   Delete6G   �� 53      -   5        $��2��53      .��67   Add6<   54      55      56      