   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Diplom.ViewDiplom.View  5      %clr-namespace:Diplom.VM	Diplom.VM  5      clr-namespace:DiplomDiplom  5	          Diplom.View.PageAddEvent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:Diplom.View  5       VMclr-namespace:Diplom.VM  5      !diplomclr-namespace:Diplom  5	      -   5        $
��page��5   D     N� Title$1  +Добавление мероприятия��6      Page#��[  6&    � DataContext 5         Diplom.AddEventVM  5   
   .��5      � .+�5   
   �� $��30q�6   $��Center=�6   $4��.Информация о мероприятии��6<   $	��400��6^   $��0��5      .��5      �� $��Disabled=�6   $��Stretch=�6D   $
��Auto=�5      .��5      ��  �� Orientation$ Vertical=�6   $��Center=�64   .+�5      ��  �� 	MaxLength$ 25��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название��5      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . ��5      �� *eventAdded.Name+�� 5      $��50��5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      $ Описание��5        . ��5"      �� *eventAdded.Description+�� 5#      $ Направление��6   ��6L   �� *
directions+	 �� SelectedItem	 5$      �� *selectedDirection+��5%      �� 5&      .R�5'   "   �� ��6,   �� 
 �� Path$

 Name�5(      5*          Diplom.View.AddCompetecios  5-      $	��380��6+   $	��250��67    5.   +   ��  �� ElementName$
 page��$
 DataContext��� 5/      
 � Tag$ 98��6   $��25q�6&     MaterialDesignRaisedButton#��[ 50      $	��150��51       � ToolTip$Y SДля сохранения необходимо заполнить все поля��52      ��53      �� *
AddEvent+.��54      �� 
�������$��0,0,0,3q�67   Сохранить56      57      58      59      5:      5;      5<      