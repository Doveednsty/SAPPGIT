   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      ? ;SApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SApp.Pages
SApp.Pages 5         SApp.Pages.AnalyticsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      Blvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf    5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SApp.Pages     5      -   5          N� 
FontFamily$  Ubuntu)�5       N� Title$ AnalyticsPage��5       � 	Resources 5       �� 
TargetType �� Property �� Value��%\   '	�       �� 5   
   " 	�6   .�5      ��  � �� �#5ab9ea5      5      5      .��5      � .+�5   
   � $��	50,35,0,0q�6    � RowDefinitions 5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��6* �6    .+�5       �� $��Center=�5!      $��Center=�5"      $��0��5#      $��0,30,0,0q�5$       �� Orientation$ 
Horizontal=�5%      .+�5'      �� $#��Выберите акцию: ��5(      $��20(�5)      $��50,0,0,0q�5*      5,      �� 5.      -   5         ��Name$ ChooseShareCB��5/      $	��300��50      $��20,0,0,0q�51      53      5C      �� 5F      $��1��6   $ 
Horizontal=�5G      $��Bottom=�5H      $��Center=�5I      $��0,0,0,15q�5J      .+�5N      �� -   5        	 ��Name$	 
AllTimebtn��5O   !   $��За все время��5N   !   $��0,0,60,0q�5R   !   $��0q�5S   !   
������ ���#2525255X      �� 5[      -   5        $	 Yearbtn��5\   !   $��Год��5[   !   $��0,0,60,0q�5_   !   $��0q�5`   !   
������ ���#2525255d      �� 5g      -   5        $	 SixMonthbtn��5h   !   $��6 месяцев��5g   !   $��0,0,60,0q�5k   !   $��0q�5l   !   
������ ���#2525255p      �� 5r      -   5        $	 ThreeMonthbtn��5s   !   $��3 месяца��5r   !   $��0,0,60,0q�5v   !   $��0q�5w   !   
������ ���#2525255{      �� 5}      -   5        $	 Monthbtn��5~   !   $��
Месяц��5}   !   $��0,0,60,0q�5�   !   $��0q�5�   !   
������ ���#2525255�      �� 5�      -   5        $	 Weekbtn��5�   !   $��Неделя��5�   !   $��0,0,60,0q�5�   !   $��0q�5�   !   
������ ���#2525255�      �� 5�      -	   5        $	 Daybtn��5�   !   $��День��5�   !   $��0,0,60,0q�5�   !   $��0q�5�   !   
������ ���#2525255�      �� 5�      -
   5        $	 AtNowbtn��5�   !   $��Сейчас��5�   !   $��0,0,60,0q�5�   !   $��0q�5�   !   
������ ���#2525255�      5�      �� 5�      -   5        $	 Calc_btn��5�      $��Right=�5�      $��Bottom=�5�      $��	0,0,70,10q�5�      
������ ���#5ab9ea���#252525+  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth0=�5�      $��Показать��5�      $��0��5�      5�      #   LiveCharts.Wpf.CartesianChart  5�      $��3��6!   &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�6R      Series 6.   �� *SeriesCollection+   AxisY 5�         LiveCharts.Wpf.Axis     Title$ Цена��6      LabelFormatter 6,   �� *
YFormatter+6T      AxisX 5�        $ День��6      Labels 6,   �� *Labels+6H   5�      5�      5�      5�      