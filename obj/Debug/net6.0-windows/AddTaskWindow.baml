   M S B A M L   `   `   `  ����F  Bkursach_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:kursach_wpfkursach_wpf  5   	       kursach_wpf.AddTaskWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:kursach_wpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Window1��5	   	   $	��500��6   $	��400��6&   .��5
      � .+�5   
   �� -   5        $��Name_TB��5      $��Stretch=�6!   $��	26,58,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $��Имя��6f   $	��Top=�6q   6�   �� 5   
   -   5        $��Desc_TB��5      $��Stretch=�6!   $��
26,116,0,0q�6?   $
 Wrap=�6S   $��Описание��6g   $	��Top=�6�   �� 5   
   -   5        $��Сохранить��5      $��Right=�6%   $��	0,0,15,15q�6A   $��Bottom=�6T   6o   )  #MaterialDesignThemes.Wpf.TimePicker  5   
   -   5        $��
Start_Time��5   %   $
��Left=�67   $��
26,192,0,0q�6R   $	��Top=�6f    J� RenderTransformOrigin$ 1.091,-0.193&�6~      	Is24Hours$
 True��6�   �� 5   
   $��Время начала��6   $
��Left=�6'   $��
26,163,0,0q�6B   $	��Top=�6V     5   
   -   5        $��End_Time��5   %   $
��Left=�65   $��
26,251,0,0q�6P   $	��Top=�6d   $ 1.091,-0.193&�6|   $
 True��6�   �� 5   
   $#��Время окончания��6   $
��Left=�6*   $��
26,222,0,0q�6E   $	��Top=�6Y   5      5      