   M S B A M L   `   `   `  ����D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  5   	   -    'TravelHub.Меню_сотрудника   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TravelHub     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$# Меню сотрудника��5	   	   $��446.8��6!   $��573.3��60   .��5
      � ��5   
   �� 5       �� ImageSource$4 ./Изображения/MainMenuBackground.jpg��6    � ColumnDefinitions 5   
   �� 5      $��0* �6   6,   �� 5      $
��479* �6   �� 5      $	��88* �6   �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��59* �6   6+   �� 5      $	��59* �6   6+   �� 5      $	��59* �6   6+   �� 5      $	��22* �6   6+   �� 5      $	��38* �6   .+�5   
   �� -   5         ��Name$ toPersonalReservations��5   J   $��Right=�6   $)��#Каталог бронировки��6-   $��1��6j   $��Center=�6z   $��21(�6�   $	��244��6�   ���	#FF431BAC$��46��6�   $��	0,5,235,9q�6�   $��2��6�   $��Comic Sans MS)�6
  $
��Bold"�6%  
���   �67  �� 5   
   $��24(�6   $��0��6"   $��0��62   $��
7,-2,23,20q�6?   ���	#FF4348AE$��3��6j   $��Center=�6~   $	��537��6�   $��Center=�6�   �� 6�   $
��Bold"�6�   $��36(�6�   $��Informal Roman)�6�   $�	TravelHub��6   �� TextDecorations$ 	Underline{�6  �� 62  $
��Bold"�66  $��36(�6H  $��Informal Roman)�6V  $� ��6r  �� 6}  $��Comic Sans MS)�6�  $�Cотрудник  ��6�  6�  �� 5    
   ���	#FF4348AE$
��Left=�6%   $��45��6@   
���   �$��Bottom=�6[   $	��538��6v   $��14,0,0,-1.2q�6�   $��6��6�   $��3��6�   $��2��6�   �� 5!   
   $��85��6   $
��Left=�6   $��Close��67   $��6��6G   $��16(�6T   $��28,20.2,0,5.8q�6b   $��
Выход��6y   $��2��6�   $��Comic Sans MS)�6�   
���   �
���   ����	#FF431BAC$��2��6�   �� 5"   
   $��20.835,3,22.817,22.104q�6   $,��&/Изображения/IconForApp.ico��60   $
��Fill=�6U   $��2��6d   �� 5#   
   -   5         ��Name$ userNameBox��5#      $��24(�6%   $��Bottom=�64   $
��Bold"�6V   $��Italic$�6h   $��35��6{   $	��202��6�   $��Center=�6�   $��Center=�6�   $��3��6�   $��281,3,84.2,22q�6�   $��Comic Sans MS)�6�   5$       J� CommandBindings 5%      )  #System.Windows.Input.CommandBinding  5&   
   -   5        	   Command$	 Close��5&      6)   5(      