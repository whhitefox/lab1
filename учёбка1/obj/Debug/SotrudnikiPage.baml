   M S B A M L   `   `   `  ����H  Dучёбка1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:учёбка1учёбка1  5      "    учёбка1.SotrudnikiPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:учёбка1     5        N� Title$  SotrudnikiPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��228* �6   �� 5      $	��53* �6   �� 5      $	��46* �6   �� 5      $	��41* �6   �� 5      $	��41* �6   �� 5      $	��41* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SotrudnikGrid��5   4   $��0��6   $��2��6    $��3��6K   6\   �� 5   
   $��2��6   $��0��6!   $��Имя:��61   $��Center=�6=   $
��Left=�6X   $��	107,0,0,0q�6s   �� 5   
   -   5         ��Name$ NameTextBox��5      $��2��6'   $��Center=�64   $��2��6O   $��	133,0,0,0q�6c   �� 5   
   $��3��6   $��0��6!   $��Id животного:��61   $��Center=�6F   $
��Left=�6a   $��57,0,0,0q�6|   �� 5   
   -   5        $ AnimalsidTextBox��5      $��3��6,   $��Center=�69   $��2��6T   $��	133,0,0,0q�6h   �� 5   
   -   5         ��Name$ 	AddButton��5      $��4��6$   $��2��61   $+��%Добавить Сотрудника��6E   6c   �� 5   
   -   5        $ DeleteButton��5      $��1��6'   $��2��64   $)��#Удалить Сотрудника��6H   $��0,0,0,10q�6�   $��1��6�   �� 5    
   -   5        $ UpdateButton��5       $��5��6'   $��2��64   $+��%Изменить Сотрудника��6H   $��0,0,0,10q�6�   $��1��6�   5!      5"      