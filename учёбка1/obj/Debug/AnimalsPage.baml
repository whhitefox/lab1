   M S B A M L   `   `   `  ����H  Dучёбка1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:учёбка1учёбка1  5          учёбка1.AnimalsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:учёбка1     5        N� Title$  AnimalsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��251* �6   �� 5      $	��42* �6   �� 5      $	��34* �6   �� 5      $	��41* �6   �� 5      $	��41* �6   �� 5      $	��41* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AnimalsGrid��5   4   $��0��6   $��2��6    $��5��6I   6Z   �� 5   
   $��2��6   $��0��6!   $��Название:��61   $��Center=�6B   $
��Left=�6]   $��78,0,0,0q�6x   $��15��6�   $��55��6�   �� 5   
   -   5         ��Name$ NameTextBox��5      $��2��6'   $��Center=�64   $��2��6O   $��	133,0,0,0q�6c   $��17��6v   �� 5   
   $��3��6   $��0��6!   $��Количество:��61   $��Center=�6D   $
��Left=�6_   $��67,0,0,0q�6z   $��2��6�   $��15��6�   $��67��6�   �� 5   
   -   5        $ AmountTextBox��5      $��3��6)   $��Center=�66   $��2��6Q   $��	133,0,0,0q�6e   $��17��6x   �� 5   
   -   5         ��Name$ 	AddButton��5      $��4��6$   $��2��61   $'��!Добавить Животное��6E   6a   �� 5   
   -   5        $ DeleteButton��5      $��1��6'   $��2��64   $%��Удалить Животное��6H   6c   �� 5    
   -   5        $ UpdateButton��5       $��5��6'   $��2��64   $'��!Изменить Животное��6H   6d   5!      5"      