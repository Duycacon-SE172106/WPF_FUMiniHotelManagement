   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   '    !FUMiniHotelManagement.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $
��Auto �6   .+�5#   
   �� $��Admin Window��6   $��0��6'   $��0��67   $��36(�6D   $��4��6R   $��Center=�6f   �� 5$   
   -   5        $��RoomInformation��5$      $	��115��6+   $��50��67   $��0��6C   $��1��6S   
������� �� TextAlignment$ Center=�6w   $��Center=�6�   $��5q�6�    �� Padding$ 10q�6�   $
��Wrap=�6�   �� 5%   
   -   5        $��RoomType��5%      $	��115��6$   $��50��60   $��0��6<   $��2��6L   
�������$ Center=�6p   $��Center=�6�   $��5q�6�   $ 10q�6�   $
��Wrap=�6�   �� 5&   
   -   5        $��Manage Customer��5&      $	��115��6+   $��50��67   $��0��6C   $��3��6S   
�������$ Center=�6w   $��Center=�6�   $��5q�6�   $ 10q�6�   $
��Wrap=�6�   �� 5'   
   -   5        $��Booking Reservation��5'      $	��115��6/   $��50��6;   $��0��6G   $��4��6W   
�������$ Center=�6{   $��Center=�6�   $��5q�6�   $ 10q�6�   $
��Wrap=�6�   �� 5(   
   -   5        $��Booking Detail��5(      $	��115��6*   $��50��66   $��0��6B   $��5��6R   
�������$ Center=�6v   $��Center=�6�   $��5q�6�   $ 10q�6�   $
��Wrap=�6�   &   System.Windows.Controls.DataGrid  5)   
   -   5        	  Name$	 dgData��5)      $��1��6#   $��1��63   $��6��6@   $��3��6Q   $��4q�6e   
   AutoGenerateColumns$
 False��6p   �� 5*   
   $��1��6   $��7��6%   $��3��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5+      �� -   5         ��Name$ 
btn_Create��5+      $��Create��6)   $	��100��6:   $��30��6F   $��10q�6R   ���	#FF0099FF6u   �� 5,      -   5        $ 
btn_Change��5,      $��Change��6)   $	��100��6:   $��30��6F   $��10q�6R   ���	#FFEF8F186u   5-      5.      5/      