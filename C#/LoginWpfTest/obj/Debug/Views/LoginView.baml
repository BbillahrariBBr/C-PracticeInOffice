   M S B A M L   `   `   `  ����G  CLoginWpfTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LoginWpfTest.ViewsLoginWpfTest.Views  5      A%clr-namespace:LoginWpfTest.ViewModelsLoginWpfTest.ViewModels  5      C&clr-namespace:LoginWpfTest.ValidationsLoginWpfTest.Validations  5      "    LoginWpfTest.Views.LoginView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:LoginWpfTest.Views     5      4vm%clr-namespace:LoginWpfTest.ViewModels     5      =
validation&clr-namespace:LoginWpfTest.Validations     5        � DataContext  5      %  LoginWpfTest.ViewModels.LoginVM  5   
   .��5      ��  �� Orientation$ Vertical=�6   $��50q�5      $��Center=�5      $��Center=�5      .+�5   
   �� $��Login��6   $��25(�5      $
��Bold"�5       �� Padding$ 10q�5      $��Center=�5      $	��Top=�5      � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5       �� $��	User Name��6   $��0��5!      $
��0,15q�5"      $
��Left=�5#      �� 5$      $��1��6   $	��0,5q�5%      $	��255��5&      $
��Left=�5'      .��61   ��5(      �� 5)       �� Path$ UserName�6    �� UpdateSourceTrigger$ PropertyChanged=�5*       �� ValidationRules 5+      5   /LoginWpfTest.Validations.UserNameValidationRule  5,      5.      .��50       ��51      �� 52       �� 
TargetType" ��6    �� Triggers 53      P� 54      	 P� Property	 �@=�HasError
 P� Value
 . . �55   "   ��  �� Property �@�ToolTip �� Value 56   )   ��  �� Self �� RelativeSource# Z $&  (Validation.Errors)/ErrorContent�58      5:      .��5;   !   5<      �� 5>      $��Password��6   $��2��5?      $
��0,15q�5@      $
��Left=�5A      �� 5B      $��3��6   $	��0,5q�5C      $	��255��5D      $
��Left=�5E      .��61   ��5F      �� 5G      $ Password�6   $ PropertyChanged=�5H       5I      5   /LoginWpfTest.Validations.PasswordValidationRule  5J      5L      .��5N       ��5O      �� 5P      " ��6    5Q      P� 5R      	 �@=�HasError
 . . �5S   "   ��  �@�ToolTip 5T   )   �� # Z $&  (Validation.Errors)/ErrorContent�5V      5X      .��5Y   !   5Z      5\      �� 5^   
   -   5         ��Name$ btnLogin��5^      $��Login��5_      
�������
���   �$
��0,25q�5b      $��35��5c      $	��250��5d      ��5e      �� *LoginCommand+��5f      �� *
UserName+5h      5j      