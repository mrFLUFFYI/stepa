   M S B A M L   `   `   `  ����?  ;BATS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BATSBATS  5   	       BATS.Igroki   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BATS     5   	   -   5          � Title$!  Игроки команды��5   	   $	��600��6    $	��900��6-    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u    � WindowStyle$
 None=�6�    � 	Resources 5	         ComboBoxTest2 �� 
TargetType �� Property �� Value �� 
TargetType	 d� 	IsChecked
 �� Path �� Mode �� RelativeSource � ColumnDefinitions ��Name F�Name �� Triggers P� Property P� Value �� 
TargetName J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost  �� Triggers��%�  &	        �� 5
   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      d� $��2��6+   |�.  	 6M   �� $
 IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+��5   "   �� 5   &   .R�5   *   �  5   .   �� 5   2   $��5* �6C   �� 5   2   $��* �6C   .+�5   .   �� $ Border��65   $��2��6E   
���   ����	#FFFFA800$��1q�6�   �� 5   .   $��0��65   $��1q�6E   
���   �
���   �$��0,0,1,0q�6w   F� 5   .   $ Arrow��63   $��1��6B   ���	#FFFFA800$��Center=�6d   $��Center=�6�   "����        � 	=  	= � z     	6�   5   +    5   *   P� 5   .    �@J�IsMouseOver . . �5   2   �� $ Border��69    � �� �	#FFFFA8006c   5   /   P� 5   .    �@d�	IsChecked$
 trueY�6X   . �5    2   �� $ Border��69    � ��
 �   �6c   5!   /   5#   '   5%      �� 5&      $��ContentSite��6/    .  #��z 6\   #��z 6�   #��z��6�   $��3q�6  �� 5'      $ PART_EditableTextBox��6&   $y�Hidden=�6D   # z 6X   � 5(      $��Popup��6$   $��Bottom=�61   #��z 6D    . |�.  $��Slide=�6�   .��5)   "   � $��DropDown��6(    . #��z 6S   #��z 6|   .+�5*   &   �� $ DropDownBorder��6-   
���   �6E   �� 5+   &    . .��5,   *   ��  . 65   5-   '   5.   #   5/      50      51      53        54      56      57      .��58      � ���	#FF009244.+�59   
   �� $
��Left=�6   $	��603��6+   $��-129,-3,0,0q�68   $	��Top=�6M   $
��1855��6e   $��/Images/bg.png��6r   �� 5:   
   $��Center=�6   $	��506��61   $��0,84,0,0q�6>   ���	#FFFFA800$	��Top=�6c   $	��880��6{   ���	#7F0000006�   �� 5;   
   $
��Left=�6   $��82��6/   $��0,-3,0,0q�6;   ���	#FF353535$	��Top=�6`   $	��900��6x   ���	#FFFFA8006�   �� 5<   
   $
��Left=�6   $��67��6+   $��10,4,0,0q�67   $	��Top=�6I   $��55��6a   $��/Images/logoWhite.png��6l   �� 5=   
   -   5        ! ��Name$! Vihod��5=      $��Назад ->��6    $
��Left=�66   $��
750,22,0,0q�6Q   $	��Top=�6e   $	��125��6}   $��32��6�   $��18(�6�   ���	#FFFFA800
���   �
�������6�   �� 5>   
   $!��Игроки команды��6   $
��Left=�6)   $��
248,-3,0,0q�6D   $	��Top=�6X   $��48(�6p   $
��Bold"�6~   
���������6�   Z� 6�   &   System.Windows.Controls.DataGrid  5@   
   -   5        "  Name$" table��5@      $��Center=�6"   #   AutoGenerateColumns# .  $	��192��6[   $	��Top=�6h   $	��850��6�   
�������$��	0,154,0,0q�6�   ���	#FFFFA800
���   � 5A      =  7System.Windows.Controls.Primitives.DataGridColumnHeader$ �� BasedOn*  $System.Windows.Controls.DataGridCell��%>  '        7 '  g    7 �� 5B      8$   "  6Q   .�5C      ��  � �� �	#FFFFA80063   �� 5D       � ��
 �����63   �� 5E       � ��
 �   �64   �� 5F       � ��$ 1 1 1 1q�68   �� 5G       � ��$ 	-1,-1,0,0q�6/   �� 5H       � ��$ 28��6/   �� 5I       � ��$
 auto��6.   �� 5J       � ��$ Center=�6C   5K      �� 5L      8$   "  6I   .�5M      ��  � ��
 �   �63   �� 5N       � ��
 �����63   �� 5O       � �� �	#FFFFA80064   �� 5P       � ��$ 1 1 1 1q�68   �� 5Q       � ��$ 	-1,-1,0,0q�6/   �� 5R       � ��$ 28��6/   �� 5S       � ��$
 auto��6.   �� 5T       � ��$ Center=�6C   �� 5U       � ��$ Disabled=�6S   �� 5V       � ��$ Disabled=�6Q   5W      5X      %   Columns% 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn&   Header$& ID��6C   '   Width5  /System.Windows.Controls.DataGridLengthConverter$
' 0.2* 6O   1  +System.Windows.Controls.DataGridBoundColumn(   Binding( 6%   �� *	id_igroka+6O     5[      $& ФИО��6%   $' 1* 62   ( 5\      `� 5]      ) �� StringFormat$) {0} {1} {2}��6'   .1�5^      �� $
 familia�6&   �� 5_      $	
 ima�6&   �� 5`      $
 	otchestvo�6&   5a      5c        5d      $& Дата рождения��6W   $
' 0.5* 6n   ( 6%   �� *data_rojdenia+$) d��6n     5e      $& Амплуа��6B   $
' 0.5* 6R   ( 6%   �� *
nazvanie+6R     5f      $& Игровой номер��6G   $
' 0.5* 6^   ( 6%   �� *igrovoi_nomer+6^     5g      $& 
Логин��6?   $
' 0.5* 6N   ( 6%   �� *login+6N     5h      $& Пароль��6?   $
' 0.5* 6O   ( 6%   �� *parol+6O   5j      �� 5k   
   -   5        $ Poisk��5k      $
��Left=�6!   * �� TextAlignment$
* Left=�6<   + �� TextWrapping$
+ Wrap=�6Q   $	��Top=�6e   $	��220��6~   $��107,114,0,0q�6�   $��18(�6�   
�������$��31��6�   ���	#FFFFA800
���   �6  �� 5l   
   $��Поиск:��6   $
��Left=�6!   $��
30,110,0,0q�6<   $	��Top=�6P   $��18(�6h   
�������6v   �� 5m   
   -   5        $! SortA��5m      $��Сортировать��6    $
��Left=�66   $��332,114,0,0q�6Q   $	��Top=�6f   $	��179��6~   $��18(�6�   ���	#FFFFA800
���   �
�������$��31��6�   �� 5n   
   -   5        $! dobav��5n      $��Добавить��6    $
��Left=�63   $��223,530,0,0q�6N   $	��Top=�6c   $	��150��6{   $��18(�6�   ���	#FFFFA800
���   �
�������6�   �� 5o   
   -   5        $! izmenit��5o      $��Изменить��6"   $
��Left=�65   $��380,530,0,0q�6P   $	��Top=�6e   $	��150��6}   $��18(�6�   ���	#FFFFA800
���   �
�������6�   �� 5p   
   -   5        $! udalit��5p      $��Удалить��6!   $
��Left=�63   $��535,530,0,0q�6N   $	��Top=�6c   $	��150��6{   $��18(�6�   ���	#FFFFA800
���   �
�������6�   �� 5r   
   -	   5        , ��Name$, idTxt��5r      $
��Left=�6"   $	��Top=�6=   $��50��6V   $��
38,402,0,0q�6a   $��18(�6u   
�������$��28��6�   #��[  6�   �� 5s   
   -
   5        $ FamTxt��5s      $
��Left=�6"   $	��Top=�6=   $
+ Wrap=�6U   $	��125��6i   $��
93,402,0,0q�6u   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �6�   �� 5t   
   -   5        $ ImaTxt��5t      $
��Left=�6"   $	��Top=�6=   $
+ Wrap=�6U   $	��125��6i   $��223,402,0,0q�6u   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �6�   �� 5u   
   -   5        $ OtchTxt��5u      $
��Left=�6#   $	��Top=�6>   $
+ Wrap=�6V   $	��125��6j   $��353,402,0,0q�6v   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �6�   (  "System.Windows.Controls.DatePicker  5v   
   -   5        -  Name$- DataTxt��5v      $
��Left=�6&   $	��Top=�6A   $	��125��6Y   $��483,402,0,0q�6e   
�������$��28��6�   ���	#FFFFA800
���   � 5w      :	  4System.Windows.Controls.Primitives.DatePickerTextBox. ��Name��%�  '	        �� 5x      " 	 6   .�5y      ��  � ��
 ���� 63   �� 5z       � ��
 ���� 64   �� 5{       � ��
 �����63   �� 5|       � ��$ 14(�61   �� 5}       � ��$ 2q�60   �� 5~       � �� 5      �� 5�      " 	 6.   .R�5�   "   �� #��z��6)   $��1q�6U   #��z��6i   ._�5�   &   �� $. PART_ContentHost��63   5�   #   5�      5�      5�      5�      5�      �� 5�   
   -   5        $ LoginTxt��5�      $
��Left=�6$   $	��Top=�6?   $
+ Wrap=�6W   $	��125��6k   $��613,402,0,0q�6w   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �6�   �� 5�   
   -   5        $ ParolTxt��5�      $
��Left=�6$   $	��Top=�6?   $
+ Wrap=�6W   $	��125��6k   $��743,402,0,0q�6w   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �6�   �� 5�   
   -   5        $, 	AmpluaTxt��5�      $
��Left=�6&   $	��Top=�6A   $	��125��6Y   $��322,474,0,0q�6e   $��18(�6z   
�������$��28��6�   #��[  6�   �� 5�   
   -   5        $ NomerTxt��5�      $
��Left=�6$   $	��Top=�6?   $
+ Wrap=�6W   $	��125��6k   $��452,474,0,0q�6w   $��18(�6�   
�������$��28��6�   ���	#FFFFA800
���   �/ �� 	MaxLength$/ 3��6  �� 5�   
   $��ID��6   $
��Left=�6   $��
49,368,0,0q�68   $	��Top=�6L   $��18(�6d   
�������6r   �� 5�   
   $��Фамилия��6   $
��Left=�6"   $��113,368,0,0q�6=   $	��Top=�6R   $��18(�6j   
�������6x   �� 5�   
   $��Имя��6   $
��Left=�6   $��263,368,0,0q�69   $	��Top=�6N   $��18(�6f   
�������6t   �� 5�   
   $��Отчество��6   $
��Left=�6#   $��372,368,0,0q�6>   $	��Top=�6S   $��18(�6k   
�������6y   �� 5�   
   $��Дата рождения��6   $
��Left=�6(   $��477,368,0,0q�6C   $	��Top=�6X   $��18(�6p   
�������6~   �� 5�   
   $��
Логин��6   $
��Left=�6    $��645,368,0,0q�6;   $	��Top=�6P   $��18(�6h   
�������6v   �� 5�   
   $��Пароль��6   $
��Left=�6!   $��770,368,0,0q�6<   $	��Top=�6Q   $��18(�6i   
�������6w   �� 5�   
   $��Амплуа��6   $
��Left=�6!   $��349,440,0,0q�6<   $	��Top=�6Q   $��18(�6i   
�������6w   �� 5�   
   $��
Номер��6   $
��Left=�6    $��482,440,0,0q�6;   $	��Top=�6P   $��18(�6h   
�������6v   �� 5�   
   -   5        $! Obnov��5�      $��Обновить��6    $
��Left=�63   $��516,114,0,0q�6N   $	��Top=�6c   $	��180��6{   $��18(�6�   ���	#FFFFA800
���   �
�������$��31��6�   5�      5�      