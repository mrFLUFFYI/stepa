   M S B A M L   `   `   `  ����?  ;BATS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BATSBATS  5   	       BATS.TurnirK   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BATS     5   	   -   5          � Title$  Турниры��5   	   $	��500��6   $	��900��6&    � WindowStartupLocation$ CenterScreen=�6I    � 
ResizeMode$ NoResize=�6n    � WindowStyle$
 None=�6�   .��5	      � ���	#FF009244.+�5
   
   �� $
��Left=�6   $	��503��6+   $��-129,-3,0,0q�68   $	��Top=�6M   $
��1565��6e   $��/Images/bg.png��6r   �� 5   
   $��Center=�6   $	��406��61   $��0,84,0,0q�6>   ���	#FFFFA800$	��Top=�6c   $	��880��6{   ���	#7F0000006�   �� 5   
   $
��Left=�6   $��82��6/   $��0,-3,0,0q�6;   ���	#FF353535$	��Top=�6`   $	��900��6x   ���	#FFFFA8006�   �� 5   
   $
��Left=�6   $��67��6+   $��10,4,0,0q�67   $	��Top=�6I   $��55��6a   $��/Images/logoWhite.png��6l   �� 5   
   -   5         ��Name$ Vihod��5      $��Назад ->��6    $
��Left=�66   $��
750,22,0,0q�6Q   $	��Top=�6e   $	��125��6}   $��32��6�   $��18(�6�   ���	#FFFFA800
���   �
�������6�   �� 5   
   $��Турниры��6   $��Center=�6"   $��0,-3,0,0q�6?   $	��Top=�6Q   $��48(�6i   $
��Bold"�6w   
���������6�   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ table��5      $��Center=�6"      AutoGenerateColumns .  $	��327��6[   $	��Top=�6h   $	��850��6�   
����������	#FFFFA800
���   �$��	0,149,0,0q�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn	 �� 
TargetType
 �� Property �� Value*  $System.Windows.Controls.DataGridCell��%>  '        7 '  g    7 �� 5      8   "	  6Q   .�5      �� 
 � �� �	#FFFFA80063   �� 5      
 � ��
 �����63   �� 5      
 � ��
 �   �64   �� 5      
 � ��$ 1 1 1 1q�68   �� 5      
 � ��$ 	-1,-1,0,0q�6/   �� 5      
 � ��$ 28��6/   �� 5      
 � ��$
 auto��6.   �� 5      
 � ��$ Center=�6C   5      �� 5      8   "	  6I   .�5      �� 
 � ��
 �   �63   �� 5      
 � ��
 �����63   �� 5      
 � �� �	#FFFFA80064   �� 5       
 � ��$ 1 1 1 1q�68   �� 5!      
 � ��$ 	-1,-1,0,0q�6/   �� 5"      
 � ��$ 28��6/   �� 5#      
 � ��$
 auto��6.   �� 5$      
 � ��$ Center=�6C   �� 5%      
 � ��$ Disabled=�6S   �� 5&      
 � ��$ Disabled=�6Q   5'      5(         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.2* 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	id_matcha+6O     5+      $ Турнир��6J   $
 0.5* 6Z    6%   �� *nazvanie_turnira+6Z     5,      $% Место проведения��6J   $
 0.5* 6d    6%   �� *mesto_provedenia+6d     5-      $# Дата проведения��6Y   $
 0.5* 6r    6%   �� *data_provedenia+ �� StringFormat$ d��6r   5/      �� 50   
   -   5         ��Name$ Poisk��50      $
��Left=�6!    �� TextAlignment$
 Left=�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��220��6~   $��107,106,0,0q�6�   $��18(�6�   
�������$��31��6�   ���	#FFFFA800
���   �6  �� 51   
   $��Поиск:��6   $
��Left=�6!   $��
30,100,0,0q�6<   $	��Top=�6P   $��18(�6h   
�������6v   �� 52   
   -   5        $ SortA��52      $��Сортировать��6    $
��Left=�66   $��332,106,0,0q�6Q   $	��Top=�6f   $	��179��6~   $��18(�6�   
���   ����	#FFFFA800
�������$��31��6�   �� 53   
   -   5        $ Obnov��53      $��Обновить��6    $
��Left=�63   $��516,106,0,0q�6N   $	��Top=�6c   $	��179��6{   $��18(�6�   
���   ����	#FFFFA800
�������$��31��6�   55      56      