   M S B A M L   `   `   `  ����D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  5   	   '    !TravelHub.Меню_клиента   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TravelHub     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$# Меню покупателя��5	   	   $��446.8��6!   $��573.3��60   .��5
      � ��5   
   �� 5       �� ImageSource$4 ./Изображения/MainMenuBackground.jpg��6    � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $��60 �6   6*   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��59* �6   6+   �� 5      $	��59* �6   6+   .+�5   
   �� -   5         ��Name$ toBuyerOrders��5   B   $��Right=�6   $��Ваша бронь��6-   $��3��6Y   $��0��6f   $��Center=�6v   $��21(�6�   $	��187��6�   ���	#FF431BAC$��39��6�   $��0,44,380,37q�6�   $��2��6�   $��Comic Sans MS)�6  $
��Bold"�6'  �� 5   
   -   5        $ toBuyerReservation��5   D   $��Center=�6   $��Выбор брони��6.   $��2��6`   $��0��6m   $��Center=�6}   $��21(�6�   $	��187��6�   ���	#FF431BAC$��39��6�   $��0,37,380,44q�6�   $��Comic Sans MS)�6  $
��Bold"�6  $��2��6/  �� 5   
   $��24(�6   $��0��6"   $��0��62   $��20,0,18.6,15q�6?   ���	#FF4348AE$��Informal Roman)�6l   $
��Bold"�6�   ��6�   Z� �� 6�   $��36(�6�   $�	TravelHub��6�    �� TextDecorations$ 	Underline{�6�   �� 6�   $��36(�6�   $� ��6	  �� 6  $��Normal"�6  $��Comic Sans MS)�6,  $%�Добро пожаловать��6G  6b  �� 5   
   ���	#FF4348AE$
��Left=�6%   $��44��6@   
���   �$��Bottom=�6[   $	��529��6v   $��20,0,0,-0.2q�6�   $��6��6�   �� 5   
   $��85��6   $
��Left=�6   $��Close��67   $��6��6G   $��16(�6T   $��31,18.4,0,5.8q�6b   $��
Выход��6y   ���	#FF431BAC$
��34.4��6�   $��Comic Sans MS)�6�   
���   �
���   �6�   �� 5   
   -   5         ��Name$ userNameBox��5      $��24(�6%   $��Bottom=�64   $��394,4,213.6,15q�6X   $
��Bold"�6p    J� RenderTransformOrigin$ 0.516,0.463&�6�   $��Comic Sans MS)�6�   $��Italic$�6�   5       	 J� CommandBindings	 5!      )  #System.Windows.Input.CommandBinding  5"   
   -   5        
   Command$
 Close��5"      6U   5$      