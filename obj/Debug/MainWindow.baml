   M S B A M L   `   `   `  ����M  Iruslanprackt5var10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ruslanprackt5var10ruslanprackt5var10  5   	   #    ruslanprackt5var10.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ruslanprackt5var10     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      �� 5      $��31 �6   .+�5   
   �� $��Пример 1��6   $��0��5      $��1��5      $��Center=�5      $��Center=�5      $��18��6   $��101,6,215,6q�6(   $��56��6=   �� 5   
   $��Данные��6   $��1��5      $��0��5      $
��Left=�5      $��Center=�5      $��10,6,0,6q�5       $��18��6   $��45��6   �� 5!   
   $!��Входные данные��6   $��2��5"      $��0��5#      $
��Left=�5$      $	��Top=�5%      $��	10,10,0,0q�5&      $��17��6   $��98��6    �� 5'   
   -   5         ��Name$ TextBlockAnswer��5'      $��Ответ: ��5(      $��3��5)      $��0��5+      $��2��5,      $��Stretch=�5-      $��Stretch=�5.      $��10,10,10,121q�5/      �� 50   
   -   5         ��Name$ TbNumber��50      $��1��51      $��1��52      $
��Left=�53      $��Center=�54      $
��10 0q�55      $��80��6   $��2q�56      �� 57   
   -   5         ��Name$ BtnAdd��57      $��Добавить��6!   $��1��64   $��1��58      $��	104,3,8,3q�6   ���	#FF3985B0
�������5;      �� 5<   
   -   5         ��Name$ ListBoxData��5<      $��2��5=      $��1��5>      $��Visible=�5?      $
��10 0q�5@      $��1q�5A      �� 5B   
   $��4��6   $��1��5C       �� Orientation$ 
Horizontal=�5D      $��Center=�5E      $��
40,0,160,0q�6   $	��172��62   .+�5F      �� -   5        $ BtnOK��5F      $��OK��6$   $��80��5G      $��24��6   $��3q�6   ���	#FF3985B0
������� �� 	IsDefault . 5J      �� 5K      -   5        $ 	BtnCancel��5K      $��Cancel��6(   $��80��5L      $��24��6   $��3q�6   ���	#FF3985B0
�������	 �� IsCancel	 . 5O      5P      �� 5Q   
   -   5        $��Задание 2��5Q      $��1��6%   $
��Left=�65   $��	10,76,0,0q�6P   $��3��6c   $	��Top=�6p   $��75��6�   
 J� RenderTransformOrigin$
 -0.613,0.634&�6�   6�   �� 5R   
   -   5        $��Задание 3��5R      $��1��6%   $
��Left=�65   $��
137,76,0,0q�6P   $��3��6d   $	��Top=�6q   $��75��6�   6�   �� 5S   
   -	   5        $��Задание 4��5S      $��1��6%   $
��Left=�65   $��
273,76,0,0q�6P   $��3��6d   $	��Top=�6q   $��75��6�   6�   �� 5T   
   -
   5        $��Задание 5��5T      $��1��6%   $
��Left=�65   $��
10,127,0,0q�6P   $��3��6d   $	��Top=�6q   $��75��6�   6�   �� 5U   
   -   5        $��Задание 6��5U      $��1��6%   $
��Left=�65   $��137,127,0,0q�6P   $��3��6e   $	��Top=�6r   $��75��6�   6�   �� 5V   
   -   5        $��Задание 7��5V      $��1��6%   $
��Left=�65   $��273,127,0,0q�6P   $��3��6e   $	��Top=�6r   $��75��6�   6�   5W      5X      