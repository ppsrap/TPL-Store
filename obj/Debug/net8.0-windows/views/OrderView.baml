   M S B A M L   `   `   `  ����D  @TPL Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TPL_Store.viewsTPL_Store.views  5   	       TPL_Store.views.OrderView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /localclr-namespace:TPL_Store.views     5   	     � Title$  	OrderView��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Add Order Line��6   $
��Left=�5      $	��Top=�6,   $��10q�6D   ��5   *   �� *AddOrderLineCommand+5   D   &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns$ False��6C   $��10q�6_   ��6    �� *
OrderLines+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6)      CellTemplate 5      �� 5      .R�5      ��  �� DisplayMemberPath$ ItemName��5   '    �� SelectedValuePath$ ItemId��5   '   ��5   '   �� *DataContext.Items+ �� RelativeSource �� 	 �� AncestorType
	 Window
 �� SelectedValue
 5   '   �� *ItemId+ �� Mode$ TwoWay=�5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ SKU ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ItemId+6P     5!      $ Quantity��6%   $	 100 6a    67   �� *
Quantity+$ TwoWay=�6a     5#      $ 	Item Cost��6%   $	 100 6b    68   �� *
ItemCost+$ TwoWay=�6b     5%      $ 
Line Total��6%   $	 100 6W    69   �� *	LineTotal+6W     5'      $ Action��6)    5(      �� 5)      .R�5*      �� $��Remove��6%   ��66   �� *$"DataContext.RemoveOrderLineCommand+ �� 
	 Window��5+   %   �� 5,      5.      51      52      53      