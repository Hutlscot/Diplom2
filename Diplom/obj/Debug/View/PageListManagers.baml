   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Diplom.ViewDiplom.View  5      %clr-namespace:Diplom.VM	Diplom.VM  5      "    Diplom.View.PageListManagers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Diplom.View     5      &VMclr-namespace:Diplom.VM     5         Page#��[  5
        N� Title  6   �� *Title+.��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $
��grid��5         AutoGenerateColumns .     SelectionMode$ Single=�6;      
IsReadOnly .  �� SelectedItem 6d   �� *selectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
LastName+6U     5      $ Имя��6%    62   �� *Name+6M     5      $ Отчество��6%    67   �� *
MiddleName+6X     5      $ Контакты��6%    67   �� *
Contacts+6V   5      � 5   
   $��1��6   .+�5      �� -   5        $��txt_main_manager��5      $��Center=�60   $��Center=�6M   	 �� TextAlignment$	 Center=�6h   ^\У этого направления еще нет главного руководителя6�   �� 5      $
��Left=�6   $��20q�60   $��Добавить��6<   ��6O   �� *
AddCommand+6p   �� 5      $��Right=�6   $��20q�61   $��Удалить��6=   ��6O   �� *
DelCommand+6p   5      5      5      