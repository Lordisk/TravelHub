   M S B A M L   `   `   `  ����D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  5          TravelHub.AdminRoomsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:TravelHub     5      -   5          N� Title$  AdminRoomsPage��5
      .��5      � 
�����_� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��40 �6   �� 5      �� 5      $��40 �6   �� 5      �� 5      $��40 �6   �� 5      �� 5      $��60 �6   .+�5   
   �� ._�5      �� $��ОТЕЛЬ LUJO BODRUM��6   $��DemiBold"�62   $��Times New Roman)�6H   
�������$��20(�6x   $��Center=�6�   $��Center=�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ LUJO_BODRUM��5       $��1��5         AutoGenerateColumns .     RowBackground
 �����   AlternatingRowBackground
 ��������	#FF1F33EB��5!   #   Z�    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$# Описание номера��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6H   �� *
NameRoom+  5(      $ Доступность��6%   $ * 6:   	 6D   �� *Accessibility+  5)      $$ Вместительность��6%   $ * 6>   	 6H   �� *People+  5*      $( "Стоимость за 1 день��6%   $ * 6B   	 6L   �� *	Price1day+5/      �� 50   
   $��2��6   ._�51      �� $-��'ОТЕЛЬ MAXX ROYAL_BELEK_GOLF_RESORT��6   $��DemiBold"�6C   $��Times New Roman)�6Y   
�������$��20(�6�   $��Center=�6�   $��Center=�6�   52        53   
   -   5        $" MAXX_ROYAL_BELEK_GOLF_RESORT��54      $��3��53       .  
 �����
 ��������	#FF1F33EB��55   #   Z�  5:        5;      $# Описание номера��6%   $ * 6>   	 6H   �� *
NameRoom+  5<      $ Доступность��6%   $ * 6:   	 6D   �� *Accessibility+  5=      $$ Вместительность��6%   $ * 6>   	 6H   �� *People+  5>      $( "Стоимость за 1 день��6%   $ * 6B   	 6L   �� *	Price1day+5C      �� 5D   
   $��4��6   ._�5E      �� $&�� ОТЕЛЬ STEIGENBERGER_ALCAZAR��6   $��DemiBold"�6<   $��Times New Roman)�6R   
�������$��20(�6�   $��Center=�6�   $��Center=�6�   5F        5G   
   -   5        $ STEIGENBERGER_ALCAZAR��5H      $��5��5G       .  
 �����
 ��������	#FF1F33EB��5I   #   Z�  5N        5O      $# Описание номера��6%   $ * 6>   	 6H   �� *
NameRoom+  5P      $ Доступность��6%   $ * 6:   	 6D   �� *Accessibility+  5Q      $$ Вместительность��6%   $ * 6>   	 6H   �� *People+  5R      $( "Стоимость за 1 день��6%   $ * 6B   	 6L   �� *	Price1day+5W      �� 5X   
   $��6��6   ._�5Y      �� $��ОТЕЛЬ VOYAGE_SORGUN��6   $��DemiBold"�64   $��Times New Roman)�6J   
�������$��20(�6z   $��Center=�6�   $��Center=�6�   5Z        5[   
   -   5        $ VOYAGE_SORGUN��5\      $��7��5[       .  
 �����
 ��������	#FF1F33EB��5]   #   Z�  5b        5c      $# Описание номера��6%   $ * 6>   	 6H   �� *
NameRoom+  5d      $ Доступность��6%   $ * 6:   	 6D   �� *Accessibility+  5e      $$ Вместительность��6%   $ * 6>   	 6H   �� *People+  5f      $( "Стоимость за 1 день��6%   $ * 6B   	 6L   �� *	Price1day+5k      �� 5m   
   $��8��6   $��Center=�5n   	   
 �� Orientation$
 
Horizontal=�5o   	   $��Center=�5p   	   .+�5t      �� -   5        $	��120��5t      $ ��Редактировать��5u   	   $
��10 0q�5w   	   $��15(�5x   	   
���OO/�
�������63   �� 5z      -   5        $��25��5z      $��Сохранить��5|   	   $	��100��5}   	   $��15(�6   $
��10 0q�5~   	   
���OO/�
�������63   �� 5�      -   5        $��25��5�      $��Добавить��5�   	   $	��100��5�   	   $��15(�6   $
��10 0q�5�   	   
���OO/�
�������63   �� 5�      -	   5        $��25��5�      $��Удалить��5�   	   $	��100��5�   	   $��15(�6   $
��10 0q�5�   	   
���OO/�
�������63   5�      �� 5�   
   $��0��6   $
 
Horizontal=�5�   	   $��Center=�5�   	   $��Center=�5�   	   5�      5�      