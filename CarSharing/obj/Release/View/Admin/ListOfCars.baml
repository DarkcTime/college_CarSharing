   M S B A M L   `   `   `  ���� E  ACarSharing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarSharing.View.AdminCarSharing.View.Admin  &     CarSharing.View.Admin.ListOfCars   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:CarSharing.View.Admin       N� Title$  
ListOfCars��.���  � RowDefinitions �� �� $��4* ��� .+��� $
��Bold"�List of cars� $��1�� � ColumnDefinitions �� $
��0.7* ��� .+��� $��Selected Car��
���   �$��5q�.����  �� Orientation$ Vertical=�.+��� $��	0 10 0 10q�����  �� Path$	 VIN��� -   $��CmbTypeOfCar�� �� DisplayMemberPath$ NameType��$��	0 10 0 10q� �� SelectedItem �� $ 
TypeOfCar1��� -   $��
CmbCarMake��$ NameMake��$��	0 10 0 10q� �� $ CarMake1��� -   $��CmbCarColor��$ 	NameColor��$��	0 10 0 10q� �� $ 	CarColor1��� -   $��CmbTypeEngine��$ 
NameEngine��$��	0 10 0 10q� �� $ TypeEngine1�&   System.Windows.Controls.DataGrid  -   $��ListCars��$��1��   
IsReadOnly .    AutoGenerateColumns .  $��5q�	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 *    Header$
 Make��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $ CarMake1.NameMake�  $
 * $
 Type�� �� $ TypeEngine1.NameEngine�  $
 * $ Price in minute�� �� $ TypeOfCar1.PriceInMinute�� $��2�� �� �� �� .+��� -   .��Save�� -   $��1��.��Delete�� -   $��2��.��Add