   M S B A M L   `   `   `  ���� D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  &     TravelHub.Авторизация   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:TravelHub       � 
ResizeMode$  NoResize=� � Title$ Авторизация��$��446.8��$��573.3��.��� $��0,0,-5.6,-0.2q� � ColumnDefinitions �� $	��63* ��� $
��427* ��� $	��75* ��� $	��14* �����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF851AC3��� $ 	#FF201C9F�� � Offset$ 0.694Q�� $ 	#FF020843��$ 1Q�.+��� ���	#FF4348AE$��42��
���   �$	��Top=�$��10,376,0,-1q�$
��Left=�$	��542��$��3���� ���	#FF4348AE$
��Left=�$��42��
���   �$	��Top=�$	��542��$��	10,-8,0,0q�$��3���� $��Авторизация��$��42��$��143.6,-6,0,0q�$	��Top=�$��21(�$
��Left=�$	��235��$��Comic Sans MS)�$��Italic$�$��1���� -    ��Name$ 
LoginInput��$
��Left=�$	��Top=�$��21(�$��40��$��104.8,91,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��225��$��Comic Sans MS)�$��1���� -   	 ��Name$	 ButtonEnterApp��$	��Top=�$
��Left=�$��21(�$��
Войти��$��40��$��
53,209,0,0q�$	��225��$��Comic Sans MS)����	#FF431BAC
���   �$��2���� -   $	 ButtonEnterAsGuest��$	��Top=�$
��Left=�$��21(�$"��Войти как гость��$��40��$	��225��$��104.8,254,0,0q�$��Comic Sans MS)����	#FF431BAC
���   �$��1��G� -   
 G�Name$
 PasswordInput��$��21(�$
��Left=�$��39��$��104.8,165,0,0q�$	��Top=�$	��225��$��Comic Sans MS)�$��1���� $��Логин:��$��21(�$
��Left=�$��35��$��106.8,56,0,0q�$	��Top=�$��90��$��Comic Sans MS)�$��1���� $��Пароль:��$��21(�$
��Left=�$��45��$��104.8,130,0,0q�$	��Top=�$��92��$��Comic Sans MS)�$��1���� -   $	 Registration��$*��$Зарегистрироваться��$	��Top=�$
��Left=�$��21(�$��40��$��218.8,209,0,0q�$	��225��$��Comic Sans MS)�
���   ����	#FF431BAC$��2��$��1��� -    �Name$ CaptchaGrid��$��-132,302,85.4,1q�$��2��.+��� $��Введите капчу��$��21(�$
��Left=�$	��231��$��529,-188,-241,0q�$��42��$	��Top=�$��Comic Sans MS)��� -   $ CapthaInput��$��537,-154,-153,0q�$
��Left=�$	��135��$��37��$	��Top=�$��Comic Sans MS)��� -    ��Name$ Captcha��$
��Left=�$
��Wrap=�$��529,-118,-161,0q�$	��151��$
��Bold"�$��16(� �� TextAlignment$ Center=�$��40��$	��Top=��� $�loading���� ���	#FFF4F4F5$
��Left=�$��569,-106,-130,0q�
���   �$��80��$��2��$	��Top=��� $��Close��$��16(�$��20,382,381.8,0q�$��
Выход��$��27��$	��Top=�$��Comic Sans MS)�
���   ����	#FF431BAC
���   �$��2�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -	      Command$ Close��