   M S B A M L   `   `   `  ����E  AWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WeatherApp
WeatherApp  5   	       WeatherApp.FullInfoWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WeatherApp     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  FullInfoWindow��5   	   $��394.225��6    $��399.437��61   $��394.225��6A   $��399.437��6U      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�68   
�������.��5      �  � ColumnDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��200* �6   �� 5      $	��30* �6   �� 5      $
��200* �6   �� 5      $	��30* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��30* �6   �� 5      $
��200* �6   �� 5      $	��30* �6   �� 5      $
��200* �6   �� 5      $	��30* �6   �� 5       $��19 �6   .+�5"   
   �� $��20��6   ���	#FF29C5FF$��0��64   $��5��6A   .+�5#      �� -   5         ��Name$ CloseButton��5#      $��18��6*   $��18��65   $��0q�6A   $��0q�6U    �� Right$ 2��6a   
 �� Top$ 1��6r    / +MaterialDesignFloatingActionMiniLightButton#��[ 6�   	 � ToolTip$1	 +MaterialDesignFloatingActionMiniLightButton��5$      
�������
�������.��5%      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Close=�6*   69   5&      5'      �� 5)   
   $��1��6   $��2��6!   ���	#FF29C5FF.+�5*      ��  �� Orientation$ Vertical=�6   .+�5+      �� 
������� �� TextAlignment$ Center=�6/   $	��161��6F   $��18��6R   $��Comic Sans MS)�6^   $��0 0 0 15q�6y   Night6�   �� 5,      -   5         ��Name$ nightTemperature��5,   3   $ Center=�6   $��0 0 0 5q�6M   Temperature6l   �� 5-      -   5        $ nightFeelsLike��5-   3   $ Center=�6   $��0 0 0 5q�6K   
Feels like6i   �� 5.      -   5        $ nightWindSpeed��5.   3   $ Center=�6   $��0 0 0 5q�6K   
Wind speed6i   �� 5/      -   5        $ nightWindDirrection��5/   3   $ Center=�6   $��0 0 0 5q�6P   Wind dirrection6s   50      51      �� 52   
   $��3��6   $��2��6!   ���	#FF29C5FF.+�53      �� $ Vertical=�6   .+�54      �� 
�������$ Center=�6/   $	��161��6F   $��18��6R   $��Comic Sans MS)�6^   $��0 0 0 15q�6y   	Morning6�   �� 55      -   5        $ morningTemperature��55   3   $ Center=�6   $��0 0 0 5q�6O   Temperature6n   �� 56      -   5        $ morningFeelsLike��56   3   $ Center=�6   $��0 0 0 5q�6M   
Feels like6k   �� 57      -   5        $ morningWindSpeed��57   3   $ Center=�6   $��0 0 0 5q�6M   
Wind speed6k   �� 58      -	   5        $ morningWindDirrection��58   3   $ Center=�6   $��0 0 0 5q�6R   Wind dirrection6u   59      5:      �� 5<   
   $��1��6   $��4��6!   ���	#FF29C5FF.+�5=      �� $ Vertical=�6   .+�5>      �� 
�������$ Center=�6/   $	��161��6F   $��18��6R   $��Comic Sans MS)�6^   $��0 0 0 15q�6y   Day6�   �� 5?      -
   5        $ dayTemperature��5?   3   $ Center=�6   $��0 0 0 5q�6K   Temperature6j   �� 5@      -   5        $ dayFeelsLike��5@   3   $ Center=�6   $��0 0 0 5q�6I   
Feels like6g   �� 5A      -   5        $ dayWindSpeed��5A   3   $ Center=�6   $��0 0 0 5q�6I   
Wind speed6g   �� 5B      -   5        $ dayWindDirrection��5B   3   $ Center=�6   $��0 0 0 5q�6N   Wind dirrection6q   5C      5D      �� 5F   
   $��3��6   $��4��6!   ���	#FF29C5FF.+�5G      �� $ Vertical=�6   .+�5H      �� 
�������$ Center=�6/   $	��161��6F   $��18��6R   $��Comic Sans MS)�6^   $��0 0 0 15q�6y   	Evening6�   �� 5I      -   5        $ eveningTemperature��5I   3   $ Center=�6   $��0 0 0 5q�6O   Temperature6n   �� 5J      -   5        $ eveningFeelsLike��5J   3   $ Center=�6   $��0 0 0 5q�6M   
Feels like6k   �� 5K      -   5        $ eveningWindSpeed��5K   3   $ Center=�6   $��0 0 0 5q�6M   
Wind speed6k   �� 5L      -   5        $ eveningWindDirrection��5L   3   $ Center=�6   $��0 0 0 5q�6R   Wind dirrection6u   5M      5N      �� 5P   
   ���	#FF29C5FF$��6��6(   $��5��65   5Q      5S      