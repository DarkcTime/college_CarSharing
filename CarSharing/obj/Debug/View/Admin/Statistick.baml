   M S B A M L   `   `   `  ����E  ACarSharing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarSharing.View.AdminCarSharing.View.Admin  5      &     CarSharing.View.Admin.Statistick   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CarSharing.View.Admin     5        N� Title$  
Statistick��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   �� $
��Bold"�6   Statistick Super-Speed6>   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      $
��1.2* �6#   .+�5      �  5      �� 5      �� 5      $
��1.5* �6$   .+�5      �  5      �� 5      �� 5      .+�5       �� -   5        $��TxtNumberRent��5        67   �� 5!      -   5        $��TxtSumMonth��5!   -   $��1��6    6B   5"      �� 5#      $��1��6   
���   �$��5q�6<   $��Selected Row��6H   .��5$      � $��1��6    5%      �� 5&      �� 5'      �� 5(      .+�5*      �� -   5        $��TxtDateStart��5*   $   ��68   ��  �� Path$ CarRental.DateTimeStart� �� StringFormat$ Date start: {0}��6�   �� 5+      -   5        $��
TxtDateEnd��5+   1   $��1��6$   ��6C   �� $ CarRental.DateTimeEnd�$ Date end: {0}��6�   �� 5,      -   5        $��TxtSum��5,   1   $��2��6$   6B   5-      5.      50      &   System.Windows.Controls.DataGrid  51      -   5        $��ListRentForStatistick��51   a   $��1��6      
IsReadOnly . $��10q�69      AutoGenerateColumns .     Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)   	   Header$
	 City��63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� $ CarRental.City.NameCity�6t     54      $ * 6)   $
	 Make��63   
 6A   �� $% CarRental.Car.CarMake1.NameMake�6|     55      $ * 6)   $	 Client��63   
 6C   �� $ CarRental.User.FirstName�6w     56      $ * 6)   $
	 Time��63   
 6A   �� $
 Time�6a   58      59      5:      5;      