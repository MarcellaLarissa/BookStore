   M S B A M L   `   `   `  ����G  CBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BookStoreApp.ViewsBookStoreApp.Views  5      ?$clr-namespace:BookStoreApp.ViewModelBookStoreApp.ViewModel  6=        BookStoreApp.Views.AddBook   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:BookStoreApp.Views     5      :	viewmodel$clr-namespace:BookStoreApp.ViewModel     6=   .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5      $��10 5 0 0q�5      $��24(�5      $��Add Book��5      � 5   
   $��1��6   $��
10 20 10 0q�6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5       �� $��0��6   $��Title��6%   �� 5!      $��1��6   $��2q�5"      $��0,5,0,0q�5#      ��5$      �� *Title+5%      � 5'   
   $��2��6   $��
10 10 10 0q�6     5(      �� 5)      $
��auto �6    �� 5*      $
��auto �6    .+�5-      �� $��0��6   $��Author��6%   �� 5.      $��1��6   $��2q�5/      $��0,5,0,0q�50      ��51      �� *Author+52      � 54   
   $��3��6   $��
10 10 10 0q�6     55      �� 56      $
��auto �6    �� 57      $
��auto �6    .+�5:      �� $��0��6   $��Description��6%   �� 5;      $��1��6   $��2q�5<      $��0,5,0,0q�5=      ��5>      �� *Description+5?      � 5A   
   $��4��6   $��
10 10 10 0q�6     5B      �� 5C      $
��auto �6    �� 5D      $
��auto �6     � ColumnDefinitions 5F      �� 5G      $	��100 �6#   �� 5H      $	��100 �6#   .+�5K      �� $��0��6   $��0��5L      $��ISBN #��5M      �� 5N      $��1��6   $��0��5O      $��2q�5P      $��0 5 0 0q�5Q      ��5R      �� *ISBN+�� 5S      $��0��6   $��1��5T      $��5 0 0 0q�5U      $��Count��5V      �� 5W      $��1��6   $��1��5X      $��2q�5Y      $��5 5 0 0q�5Z      ��5[      �� *Count+5\      �� 5^   
   $��5��6   $��	10 25 0 0q�5_       �� Orientation$ 
Horizontal=�5`      .+�5a      �� $��Submit��5b      $
��10 5q�5c      $��80��5d      ��5a      �� *SubmitCommand+5d      �� 5f      $��10 0 0 0q�5g      $
��10 5q�5h      $��Cancel��5i      $��80��5j      ��5f      �� *CancelCommand+5j      5l      5n      5o      