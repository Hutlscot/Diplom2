   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5   	       Diplom.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Diplom     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��win��5	   a     � Title$0  *Виктория Петровская (с)��6	   $	��600��6)   $
��1111��66      Wind#��[  6C    � DataContext 5
         Diplom.Statuses  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   ��  K� ZIndex$	 999��6   $��1��6'   $��Center=�67   $��Center=�6T   $��20(�6o   ��6}   ��  �� ElementName$ frame�� �� Path$ Content.Title� � 5   
   -   5        $��frame��5        � NavigationUIVisibility$ Hidden=�6   $��1��6=   $��1��6M   6\   (  "MaterialDesignThemes.Wpf.ColorZone  5   
   $��0��6#   $��2��60   $��0��6D   $��51��6T   ��6`   �� $	 win��$ 
Background�.��5      � .+�5      '  !MaterialDesignThemes.Wpf.PopupBox  -   5        $��btm_back��5   *      PlacementMode$ BottomAndAlignRightEdges=�6:   $��Right=�6c   	   ToggleContent	 5      �� 5      -   5        $��Btn_Back��5   T     MaterialDesignIconButton#��[ 6!   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
���   �
   Kind$
 KeyboardBackspace=�6I   5      5       5!      5"      � 5#   
   $��0��6   $��0��6   .+�5$      �� $��16(�6   $��Меню��6&   $��Center=�62   $��Center=�6M    �� TextAlignment$ Center=�6j   5%      � 5&   
   $��Stretch=�6   $��1��6-   $��0��6:    5'      �� 5(      $��1* �6    �� 5)      $��1* �6    .+�5+      �� $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��0��6�   .��5,      �� ��6   �� *	MenuItems+��5-      �� 5.      .R�5/      ��  ��Name$ ListViewItemMenu��6*   $��-8q�6D   $��15(�6P   .��50   "   � $	��280��6'   $��46��63   .+�51   &   �� -   5         �� Padding$ 25 14q�51   P   ��52   0   �� $
 Name�53   #   54      55      57      58      �� 59      $��1��6   $	��250��6!   $��Bottom=�6-   $
��Left=�6H   $+��%/Diplom;component/Resources/logo1.jpg��6c   6�   5:      5;      5<      