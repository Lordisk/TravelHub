   M S B A M L   `   `   `  ����D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  5          TravelHub.AdminRoom3Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:TravelHub     5      -   5          N� Title$  AdminRoom3Page��5
      .��5      � 
�����_� � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��60 �6   .+�5   
   �� ._�5      �� $&�� ОТЕЛЬ STEIGENBERGER ALCAZAR��6   $��DemiBold"�6<   $��Times New Roman)�6R   
�������$��20(�6�   $��Center=�6�   $��Center=�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ STEIGENBERGER_ALCAZAR��5      $��1��5         AutoGenerateColumns .     RowBackground
 �����   AlternatingRowBackground
 ��������	#FF1F33EB��5   #   Z�    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$# Описание номера��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6H   �� *
NameRoom+  5"      $ Доступность��6%   $ * 6:   	 6D   �� *Accessibility+  5#      $$ Вместительность��6%   $ * 6>   	 6H   �� *People+  5$      $( "Стоимость за 1 день��6%   $ * 6B   	 6L   �� *	Price1day+5)      �� 5+   
   $��2��6   $��Center=�5,   	   
 �� Orientation$
 
Horizontal=�5-   	   $��Center=�5.   	   .+�52      �� -   5        $	��120��52      $ ��Редактировать��53   	   $
��10 0q�55   	   $��15(�56   	   
���OO/�
�������63   �� 58      -   5        $��25��58      $��Сохранить��5:   	   $	��100��5;   	   $��15(�6   $
��10 0q�5<   	   
���OO/�
�������63   �� 5?      -   5        $��25��5?      $��Добавить��5A   	   $	��100��5B   	   $��15(�6   $
��10 0q�5C   	   
���OO/�
�������63   �� 5E      -   5        $��25��5E      $��Удалить��5G   	   $	��100��5H   	   $��15(�6   $
��10 0q�5I   	   
���OO/�
�������63   5K      �� 5L   
   $��0��6   $
 
Horizontal=�5M   	   $��Center=�5N   	   $��Center=�5O   	   5P      5Q      