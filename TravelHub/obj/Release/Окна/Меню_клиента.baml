   M S B A M L   `   `   `  ���� D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  '    !TravelHub.Меню_клиента   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:TravelHub       � 
ResizeMode$  NoResize=� � Title$# Меню покупателя��$��446.8��$��573.3��.��� ����  �� ImageSource$4 ./Изображения/MainMenuBackground.jpg�� � ColumnDefinitions ��  � RowDefinitions �� $	��60* ��� $	��60* ��� $��60 ��� $	��60* ��� $	��60* ��� $	��59* ��� $	��59* �.+��� -    ��Name$ toBuyerOrders��$��Right=�$��Ваша бронь��$��3��$��0��$��Center=�$��21(�$	��187�����	#FF431BAC$��39��$��0,44,380,37q�$��2��$��Comic Sans MS)�$
��Bold"��� -   $ toBuyerReservation��$��Center=�$��Выбор брони��$��2��$��0��$��Center=�$��21(�$	��187�����	#FF431BAC$��39��$��0,37,380,44q�$��Comic Sans MS)�$
��Bold"�$��2���� $��24(�$��0��$��0��$��20,0,18.6,15q����	#FF4348AE$��Informal Roman)�$
��Bold"���Z� �� $��36(�$�	TravelHub�� �� TextDecorations$ 	Underline{��� $��36(�$� ���� $��Normal"�$��Comic Sans MS)�$%�Добро пожаловать���� ���	#FF4348AE$
��Left=�$��44��
���   �$��Bottom=�$	��529��$��20,0,0,-0.2q�$��6���� $��85��$
��Left=�$��Close��$��6��$��16(�$��31,18.4,0,5.8q�$��
Выход�����	#FF431BAC$
��34.4��$��Comic Sans MS)�
���   �
���   ��� -    ��Name$ userNameBox��$��24(�$��Bottom=�$��394,4,213.6,15q�$
��Bold"� J� RenderTransformOrigin$ 0.516,0.463&�$��Comic Sans MS)�$��Italic$�	 J� CommandBindings	 )  #System.Windows.Input.CommandBinding  -   
   Command$
 Close��