   M S B A M L   `   `   `  ����F  BWPF-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ProjectWPF_Project  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   ?$clr-namespace:WPF_Project.ConvertersWPF_Project.Converters  5   	   =#clr-namespace:WPF_Project.ViewModelWPF_Project.ViewModel  5	   	   L HWPF-Project.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:WPF_Project.Model;assembly=WPF-Project.ModelWPF_Project.Model 5
   	   %    WPF_Project.CustomerAdminWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_Project     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   ;
converters$clr-namespace:WPF_Project.Converters     5   	   :
viewmodels#clr-namespace:WPF_Project.ViewModel     5	   	   Lmodel:clr-namespace:WPF_Project.Model;assembly=WPF-Project.Model     5
   	     � Title$)  #FourWheel - Customer Administration��5   	   $	��450��65   $	��800��6B    � DataContext 5   	   ��    viewModelLocator �� Source# [   �� Path$ CustomerAdminViewModel� � 	Resources 5      2   ,WPF_Project.Converters.MultiBindingConverter  multiBindingConverter  enmCarBrands S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	       &	        5   
   6+   S� 5   
   $ 	GetValues��62   "  6I    5      M� 5      $ model:CarBrand��6   65   5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      �� 5      .+�5   
   ]� $��10q�6   $��0��6    .+�5       �� -   5        $��	txtFilter��5    ]   
 � ToolTip$
 Search for a customer��6   $	��Top=�66   $��0,0,0,10q�6K   ��6n   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�R� 5!      -   5         R�Name$ trvCustomers��5!      ��6-   �� *CustomerCollectionView+ 5"       �� DataType   WPF_Project.Model.Customer �� ItemsSource �� Orientation  WPF_Project.Model.Car��%<  (��       5#   /   *, +)(�� �     5(   #   *, +)�� 5#      "  6/    6R   �� *Cars+.R�5$      �� $ 
Horizontal=�6%   .+�5%      �� ��6(   �� *Name+5&      5'      �� 5(      "  6#   .R�5)      �� $ 
Horizontal=�6%   .+�5*      �� ��6(   �� *Model+5+      5,      5-      5.      5/      � 52   
   $��1��6    � RowDefinitions 53      �� 54      $
��Auto �6    �� 55      .+�58      � $��0��6    59      �� 5:      $
��Auto �6$   �� 5;      $
��Auto �6$   �� 5<      $
��Auto �6$   �� 5=      $
��Auto �6$   �� 5>      $
��Auto �6$   	 5A      �� 5B      $
��Auto �6'   �� 5C      $��* �6'   .+�5E      �� $��Add a customer!��6   $
��Bold"�63   $��24(�6E   $��2��6S    �� TextAlignment$ Center=�6g   �� 5G      -   5        $��	nameLabel��5G      $��1��6)   $��2q�66   .��6A   Name:6H   �� 5H      -   5        $��nameText��5H      $��1��6*   $��1��6:   $��2q�6G   �� 5J      -   5        $��SurnameLabel��5J      $��2q�6,   $��2��67   .��6D   
Surname:6N   �� 5K      -   5        $��surnameText��5K      $��1��6-   $��2��6=   $��2q�6J   �� 5M      -   5        $��	mailLabel��5M      $��2q�6)   $��3��64   .��6A   Mail:6H   �� 5N      -   5        $��mailText��5N      $��1��6*   $��3��6:   $��2q�6G   �� 5P      $��Add Customer��6   $��4��60   $��2��6=   $��Center=�6Q   $��10q�6n   ��6z   �� *AddCustomerCommand+��5Q      `� 5R       `� 	Converter# [ 6'   .1�5S      �� $
 Text�6&    �� ElementName$ nameText��62   �� 5T      $
 Text�6&   $ surnameText��62   �� 5U      $
 Text�6&   $ mailText��62   5V      5X      5Y      �� 5[      
���   �$��1��6)   $��0,1,0,0q�66   � 5]      $��1��6    5^      �� 5_      $��* �6$   �� 5`      $
��Auto �6$   �� 5a      $
��Auto �6$   �� 5b      $
��Auto �6$   �� 5c      $
��Auto �6$   �� 5d      $
��Auto �6$   	 5g      �� 5h      $
��Auto �6'   �� 5i      $��* �6'   .+�5l      �� $��0��6   $��2��6)   $��Add a car to customer��6=   $
��Bold"�6Z   $��24(�6l   $��Center=�6z   $��Center=�6�   �� 5n      -	   5        $��lblCustomer��5n      $��1��6+   $��0��68   $��2q�6H   .��6S   	Customer:6^   �� 5o      -
   5        $��cmbCustomer��5o      $��1��6.   $��1��6;   $��2q�6K   ��6V   �� *	Customers+��5p      �� 5q      .R�5r      �� ��6(   �� *Name+5s      5u      �� 5w      -   5        $��lblCarBrand��5w      $��2��6+   $��0��68   $��2q�6H   .��6S   
Car Brand:6_   �� 5x      -   5        $��cmbCarBrand��5x      $��2��6.   $��1��6;   $��2q�6K    �� SelectedIndex$ 0��6�   ��6V   �� # [ 6�   �� 5z      -   5        $��lblCarModel��5z      $��3��6+   $��0��68   $��2q�6H   .��6S   	Car Model6^   �� 5{      -   5        $��textCarModel��5{      $��3��6.   $��1��6;   $��2q�6K   �� 5}      -   5        $��lblCarPlate��5}      $��4��6+   $��0��68   $��2q�6H   .��6S   	Car Plate6^   �� 5~      -   5        $��textCarPlate��5~      $��4��6.   $��1��6;   $��2q�6K   �� 5�      $��Add Car��6   $��5��6+   $��2��68   $��Center=�6L   $��10q�6i   ��6u   �� *AddCarCommand+��5�      `� 5�      # [ 6'   .1�5�      �� $ SelectedValue�6&   $ cmbCustomer��6;   �� 5�      $ SelectedValue�6&   $ cmbCarBrand��6;   �� 5�      $
 Text�6&   $ textCarModel��62   �� 5�      $
 Text�6&   $ textCarPlate��62   5�      5�      5�      5�      5�      5�      