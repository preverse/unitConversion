   M S B A M L   `   `   `  ����  UnitsConversion     UnitsConversion.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   $��123.853��5   	   $��260.092��5	   	     � Title$  MVVM Light Application��5
   	    � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Skins/MainSkin.xaml?�6%   %    5      .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5   
   �� $
��Left=�5      $��24��6-   $��	10,20,0,0q�69    �� TextWrapping$
 Wrap=�5      $	��Top=�6&   $	��106��6>   ��5      �� *	FromValue+ �� Mode$ TwoWay=�5   >   �� 5   
   	 �� SelectedValuePath$	 Alias��5      
 �� DisplayMemberPath$

 Name��5      $
��Left=�5      $��
121,20,0,0q�5       $	��Top=�6   $	��113��67   ��5      �� *Units+ �� SelectedItem 5      �� *
FromUnit+$ TwoWay=�5    7   �� 5"   
    �� 
IsReadOnly . $
��Left=�6K   $��24��5#      $��
128,49,0,0q�6   $
 Wrap=�62   $	��Top=�5$      $	��106��6*   ��5"      �� *	ToValue+$ TwoWay=�5$   *   �� 5&   
   $	 Alias��5(      $

 Name��5)      $
��Left=�5*      $��	10,51,0,0q�5+      $	��Top=�6   $	��113��66   ��5&      �� *Units+ 5'      �� *ToUnit+$ TwoWay=�5+   6   5-      5.      