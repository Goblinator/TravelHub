   M S B A M L   `   `   `  ���� D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  5    /TravelHub.Бронирование_номера   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:TravelHub     -   $	��800��$	��800��  � 
ResizeMode$  NoResize=� � Title$% Оформление брони��.��� ���	#FF4348AE � RowDefinitions �� $
��124* ��� $
��247* ��� $
��199* �.+��� -    ��Name$ BasketListView��$��Center=�$	��732����. $��Visible=�$	��Top=�$	��591��$��202,29,0.043,0q�$��3�����	#FF4D0099��Z�  � ContextMenu �� .@�m� -    m�Name$ DelMEnu��$(��"Удалить из корзины������ .R��  � Orientation$ Vertical=�$��Center=�$	��800������ .R�� $��20q�$	��350����. $��Visible=� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Center=� �� TextAlignment$ Center=�$	��390��$
��Wrap=�$��Center=�$	��5 5q�$��26(�$��0������ *Название_номера+�� $��2������ *
Цена+ �� Mode$ OneWay=�	 �� StringFormat$	 Цена: {0}���� -   
 ��Name$	
 Buy��$5��/Забронировать
промежуток��$��21(�$��Center=�$
��Left=�$��59��$��10,92.296,0,0q�$	��Top=�$	��171��$��2��$��Comic Sans MS)�$
��Bold"����	#FF431BAC
���   ��� -   $

 Back��$��
Назад��$��21(�$��Center=�$
��Left=�$��38��$��10,221.296,0,0q�$	��Top=�$	��171��$��2��$��Comic Sans MS)����	#FF431BAC
���   ��� -   $	
 Del��$0��*Отменить
бронирование��$��Center=�$��21(�$
��Left=�$��60��$��10,156.296,0,0q�$	��Top=�$	��171��$��2��$��Comic Sans MS)�$
��Bold"����	#FF431BAC
���   ��� $7��1Информация о 
бронировании��$��21(�$
��Left=�$��63��$��0,-5,0,0q�$	��Top=�$	��186�� J� RenderTransformOrigin$ 0.518,0.119&�$
��Bold"����	#FF4348AE$��Comic Sans MS)��� -    ��Name$ 	resultSum��$#��Итоговая сумма:
��$��21(�$
��Left=�$��35��$��
202,-5,0,0q�$	��Top=�$	��344�����	#FF4348AE$��Comic Sans MS)��� -    ��Name$ 	SurnameBl��$
��Wrap=�$��21(�$��2,64.209,606.043,109.704q�$��1��$��Comic Sans MS)�$
��Bold"����	#FF4348AE�� $�Ваш���� $�а фамилия���� $�:���� -	   $ NameBl��$��Ваше имя:��$
��Wrap=�$��21(�$
��Left=�$��73��$	��Top=�$	��187��$��	0,158,0,0q�$y�Visible=�$��Comic Sans MS)�$
��Bold"����	#FF4348AE$��2���� -
   $ PatronymicBl��$
��Wrap=�$��21(�$��1,137.209,606.043,122.704q�$��1��$��Comic Sans MS)�$
��Bold"����	#FF4348AE�� $�	Ваше ���� $�отчество���� $�:���� -    ��Name$ SurnameInput��$��21(�$��1,97.209,0,0q� �� TextWrapping$
 Wrap=�
�������$��1��$��40��$	��Top=�$
��Left=�$	��186��$��Comic Sans MS)���Z� �� -   $ PatronymicInput��$��21(�$��1,171.209,0,0q�$
 Wrap=�
�������$��1��$��39��$	��Top=�$
��Left=�$	��186��$��Comic Sans MS)���Z� �� -   $ 	NameInput��$��21(�$
 Wrap=�
�������$��2,25.209,0,0q�$��1��$��39��$	��Top=�$
��Left=�$	��186��$��Comic Sans MS)���Z� �� -   $ PointCh��$��Отель:��$��21(�$
��Left=�$��38��$��1,58,0,0q�$	��Top=�$	��186��$��Comic Sans MS)�$
��Bold"����	#FF4348AE�� -    ��Name$ Points��$��21(� �� DisplayMemberPath$! Название_отеля�� �� SelectedValuePath$ ID_Отеля��$��0,96,0,0q�$��57��$	��Top=�$
��Left=�$	��186��$��Comic Sans MS)���Z� ��Z� �� -   $ PatronymicBl_Copy��$
��Wrap=�$��21(�$��2,211.209,605.043,62.704q�$��1��$��Comic Sans MS)�$
��Bold"����	#FF4348AE�� $$�Ваша дата въезда���� $�:���� -   $ PatronymicBl_Copy1��$
��Wrap=�$��21(�$��0,300.209,612.043,241.504q�$��1��$��Comic Sans MS)�$
��Bold"����	#FF4348AE$��2���� $�Ваша дата ���� $
�вы���� $�езда���� $�:��(  "System.Windows.Controls.DatePicker  -   $��CheckInDatePicker��$��0,271.209,591.043,20.704q�$��1��  -   $��CheckOutDatePicker��$��1,27.296,592.043,209.504q�$��2��