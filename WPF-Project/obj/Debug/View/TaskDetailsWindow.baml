   M S B A M L   `   `   `  ����F  BWPF-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_Project.ViewWPF_Project.View  5   	   ?$clr-namespace:WPF_Project.ConvertersWPF_Project.Converters  5   	   (    "WPF_Project.View.TaskDetailsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_Project.View     5   	   ;
converters$clr-namespace:WPF_Project.Converters     5   	     � Title$  FourWheel - Task Details��5	   	   $	��450��6*   $	��800��67    � DataContext 5
   	   ��    viewModelLocator �� Source# [   �� Path$ TaskDetailsViewModel� � 	Resources 5      1   +WPF_Project.Converters.NullToFalseConverter  nullToFalseConverter �� 
TargetType �� Property �� Value��%�   &	       '��        5   
   6*   �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 16(�6)   5      5      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��4* �6   �� 5!      .+�5%   
   �� $��0��6   $��0��6    $��5q�6-   .��68   	Customer:6C   �� 5&   
   $��0��6   $��1��6    $��5q�6-   .��68   Car:6>   �� 5'   
   $��0��6   $��2��6    $��5q�6-   .��68   Description:6F   �� 5(   
   $��0��6   $��3��6    $��5q�6-   .��68   Spare Parts:6F   �� 5)   
   $��0��6   $��4��6%   .+�5*      �� $��0��6   $��4��6%   $��5q�62   $	��Top=�6=   ��6U   �� *AddSparepartCommand+.��6}   Add Sparepart6�   �� 5+      $��0��6   $��4��6%   $��5q�62   $	��Top=�6=   ��5,      �� *RemoveSparepartCommand+��5-      �� *SelectedItem+
 �� ElementName$
 lvSpareParts��.��6Y   Remove Sparepart6k   5.      �� 50   
   -   5        $��cmbCustomers��50      $��1��6'   $��0��67   $��5q�6�   ��6D   �� *	Customers+ �� SelectedItem 6f   �� *SelectedCustomer+��51      �� 52      .R�53      �� ��6    �� *Name+54      56      �� 57   
   $��1��6   $��1��6#   $��5q�6  ��60   �� *SelectedCustomer.Cars+ 6^   �� *SelectedTask.Car+ �� Mode$ TwoWay=�{�6�   �� *SelectedItem+$
 cmbCustomers�� �� 	Converter# [ ��58      �� 59      .R�5:      ��  �� Orientation$ 
Horizontal=�6!   .+�5;      �� ��6$   �� *Model+�� 5<      $	�� | ��6$   �� 5=      ��6$   �� *Plate+5>      5?      5A      �� 5B   
   $��1��6   $��2��6"   $��5q�6�   ��6/   �� *SelectedTask.Description+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5C   
   -   5        $��lvSpareParts��5C      $��1��6'   $��3��67   $��2��6D   $��5q�5E       �� SelectionMode$ Single=�5F      ��5D      �� *SelectedTask.Spareparts+$ TwoWay=���5G      �� 5H      " ��6   .�5I      ��  � ��$ Center=�6C   5J       �� View 5L      �� 5M      .P�5N      �� $��Id��6%    �� Width$ 25��6U    �� DisplayMemberBinding 61   �� *Id+6U   �� 5O      $
��Name��6%   $	 150��6Y    63   �� *Name+6Y   �� 5P      $��Price��6%   $ 70��6[    64   �� *Price+6[   5Q      5S      �� 5U   
   $��5��6   $��2��6"   $��Center=�66   $ 
Horizontal=�6S   .+�5V      �� $��	Save Task��6   $��5q�6)   ��64   �� *SaveTaskCommand+6Z   �� 5W      $��Delete Task��6   $��5q�6+   ��66   �� *DeleteTaskCommand+6^   5X      5Y      5Z      