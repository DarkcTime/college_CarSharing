   M S B A M L   `   `   `  ����E  ACarSharing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CarSharing.View.ClientCarSharing.View.Client  5   	   &     CarSharing.View.Client.SelectCar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CarSharing.View.Client     5   	     � 
ResizeMode$  CanMinimize=�5       � Title$ 
Select car��5   	   $	��450��6   $	��400��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5      .+�5   
   �� $
��Bold"�6   
Select Car62   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ListCars��5   W   $��1��6   $��1��6#      AutoGenerateColumns .  $��5q�6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$
 Make��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   )   ��  �� Path$ CarMake1.NameMake�6V     5      $ * 6%   $
 Type��6/    5   )   �� $ TypeEngine1.NameEngine�6[     5      $ * 6%   $ Price in minute��6/    5   )   �� $ TypeOfCar1.PriceInMinute�6]   5      5      5      