   M S B A M L   `   `   `  ����D  @TPL Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TPL_Store.viewsTPL_Store.views  5   	   ;"clr-namespace:TPL_Store.ViewModelsTPL_Store.ViewModels  5   	       TPL_Store.views.HomeView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /localclr-namespace:TPL_Store.views     5   	   9
viewModels"clr-namespace:TPL_Store.ViewModels     5   	     � Title$  HomeView��5	   	   $	��450��6   $	��800��6'   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��Center=�6I   .+�5      �� $��Search by Order ID��6   $��Center=�61   $��10q�6L   �� 5      $	��200��6   $��10q�6"   $
��Left=�5      $��Center=�61   ��5      �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�5   1   5      �� 5   
   $��0��6   $��0��6   $��	New Order��6.   $	��100��6f   $��Right=�5       $��Center=�6-   $��10q�6H   ��5   B   �� *NewOrderCommand+5    H   &   System.Windows.Controls.DataGrid  5#   
      AutoGenerateColumns$ False��62   $��Stretch=�5$      $��Stretch=�61   $��10,10,10,10q�6M   $��1��6b   $��0��5%      ��5#      �� *Orders+ �� SelectedItem 6N   �� *SelectedOrder+   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6S   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *	OrderID+6S     5(      $ 
Ordered By��6%   $		 200 6W   
 69   �� *	OrderedBy+6W     5)      $ 
Total Cost��6%   $		 100 6W   
 69   �� *	TotalCost+6W     5*      $ Items��6%   $		 200 6\   
 64   �� *ItemsOrderedSummary+6\   5-      5.      50      