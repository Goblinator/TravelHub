   M S B A M L   `   `   `  ���� D  @TravelHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TravelHub	TravelHub  7 clr-namespace:TravelHub.CommandsTravelHub.Commands  ;    5TravelHub.Редактирование_номеров   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:TravelHub     5commands clr-namespace:TravelHub.Commands       � 
ResizeMode$  NoResize=� � Title$) #Каталог сотрудника��$	��450��$	��800��.��� ���	#FF4348AE � ColumnDefinitions �� ��  � RowDefinitions �� $��20 ��� $��30 ��� $��35 ��� $��50 ��� $
��151* ��� $	��42* ��� $
��122* �.+��� -    ��Name$ 
BorderFind��$��1q�$y�Visible=�$��6��$��2��$��6��
���   ����	#FF4348AE._��  �� $
��398* ��� $
��395* � �� �� �� �� �� .+��� -    ��Name$ 
NameSearch��$��21(�$��Center=�$��29��$��10,21.296,10.357,14.817q�
���   �$��1��$��3�����	#FFA6A6A6$��Comic Sans MS)��� -    ��Name$ NameSearchButton�� � ToolTip$3 -Поиск номера по названию��{�.  $��139,6.887,134.357,5.522q�$��2��$��3�����	#FF431BAC
���   �.���� $&�� /Изображения/Find.png���� -    ��Name$ ТипSearch��$��21(�	 �� DisplayMemberPath$	 Название_типа��$ ��9.643,21.296,10.374,14.817q�
���   �$��1��$��1��$��3�����	#FF9C9C9C$��Comic Sans MS)��� -   $* $НаличиеСкладSearchButton��$\ VПоиск номера по наличию на определенном складе��{�.  $!��150.643,6.887,116.374,4.522q�$��1��$��2��$��3�����	#FF431BAC
���   �.���� $&�� /Изображения/Find.png���� $��Center=�$��Название��$��0��$
��Bold"�$��21(�$��32��$��2��$��Center=�
 �� TextAlignment$
 Center=�$��139,11,134.357,0.409q�$	��124��$��Comic Sans MS)��� $��Bottom=�$��Тип��$��1��$
��Bold"�$��21(�$��32��$��2��$��Center=�$
 Center=�$��150.643,0,116.374,1.243q�$	��127��$��Comic Sans MS)��� $��Center=�$��Поиск номера��$��24(�$
��Bold"�$��37��$��2��$	��230��$
��Left=�$
 Center=�$��283,-3,0,10.243q�$��2��$��Comic Sans MS)�c� -    c�Name$ ToolBar1��$��2��$��115,7,0.043,10.087q�$��2��$��Comic Sans MS)���Z� .@��� -   $
 Undo��$# Отмена действия��$
��Undo��.���� $&�� /Изображения/Undo.png���� -   $	 Add��$ Добавить��$	��New��.���� $%��/Изображения/Add.png���� -	   $
 Edit��$ Изменить��%   TravelHub.Commands.DataCommands   Edit#��Z .���� $&�� /Изображения/Edit.png���� -
   $
 Save��$+ %Сохранить изменения��$
��Save��.���� $&�� /Изображения/Save.png���� -   $ Delete��$ Удалить��   Delete#��Z .���� $(��"/Изображения/Cancel.png���� -   $ Refresh��$��Refresh��$7 1Обновить данные по заказам��.���� $)��#/Изображения/refresh.png��&   System.Windows.Controls.DataGrid  -     Name$ DataGridNomer��$��1��$��21(�$��2��   
IsReadOnly .    AutoGenerateColumns .  $��6��   RowBackground
 ��İ�   AlternatingRowBackground
 �����   	RowHeight$ 31Q� � Cursor$
 Hand��$��0,29.965,0.043,109.73q�$��Comic Sans MS)�$
��Bold"����	#FF688CAF����  �� ImageSource$0 */Изображения/BaseBackGround.jpg�� �� Opacity$	 0.7Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID_Номера+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  $ Название�� �� *Название_номера+$ TwoWay=�$ PropertyChanged=�  $ Цена�� �� *
Цена+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  -   ТипChange��$ Тип��   DisplayMemberPath$ Название_типа��   SelectedValuePath$ ID_Типа��   
IsReadOnly .     SelectedValueBinding �� *ID_Типа+$ TwoWay=�$ PropertyChanged=�  -   СтатусChange��$ Статус��$% Название_статуса��$ ID_Статуса�� .   �� *ID_Статуса+$ TwoWay=�$ PropertyChanged=��� -   $ 
BackButton��$��21(�$	��100��$
��Left=�$��33��$��Bottom=�$��10,0,0,10.087q����	#FF431BAC$��
Назад��$��2��$��Comic Sans MS)�
���   �  J� CommandBindings  )  #System.Windows.Input.CommandBinding  -   !   Command#! Z   -   #! Z   -   $
! Save��  -   $
! Undo��  -   $	! New��  -   $! Refresh��