   M S B A M L   `   `   `  ���� E  ACarSharing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarSharing.View.AdminCarSharing.View.Admin  &     CarSharing.View.Admin.Statistick   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:CarSharing.View.Admin       N� Title$  
Statistick��.���  � RowDefinitions �� �� $��4* �.+��� $
��Bold"�Statistick Super-Speed� $��1�� � ColumnDefinitions �� �� $
��1.2* �.+��  �� �� $
��1.5* �.+��  �� �� .+��� -   $��TxtNumberRent���� -   $��TxtSumMonth��$��1���� $��1��
���   �$��5q�$��Selected Row��.��� $��1�� �� �� �� .+��� -   $��TxtDateStart������  �� Path$ CarRental.DateTimeStart� �� StringFormat$ Date start: {0}���� -   $��
TxtDateEnd��$��1������ $ CarRental.DateTimeEnd�$ Date end: {0}���� -   $��TxtSum��$��2��&   System.Windows.Controls.DataGrid  -   $��ListRentForStatistick��$��1��   
IsReadOnly . $��10q�   AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 	   Header$
	 City��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� $ CarRental.City.NameCity�  $ * $
	 Make��
 �� $% CarRental.Car.CarMake1.NameMake�  $ * $	 Client��
 �� $ CarRental.User.FirstName�  $ * $
	 Time��
 �� $
 Time�