   M S B A M L   `   `   `  ����M  IR12_WalidacjaRegex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:R12_WalidacjaRegexR12_WalidacjaRegex  5   	   #    R12_WalidacjaRegex.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:R12_WalidacjaRegex     5   	     � Title$  Walidacja danych (Regex)��5   	   $	��180��6*   $	��450��67    � DataContext 5	        R12_WalidacjaRegex.Osoba  5
   
      Nazwisko$ Kowalski��6      Imiona$ Jan Andrzej��6*      Pesel$ 01234567890��6@      KodPocztowy$ 40-000��6U    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%J  '��       �� 5   
   " ��6   .�5      ��  � ��$	 5q�6'   �� 5       � ��$		 120��6&   �� 5       �@=�ErrorTemplate	 5      �� 5      .R�5      � .+�5      �� �� 5      
���  ��$	��5,0q�6c   ��6(   �� *CurrentItem.ErrorContent+6c   5      5      5      5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6    � ColumnDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   .+�5'   
   �� $��	Nazwisko:��6   $��0��6$   $��0��61   �� 5(   
   $��0��6m   $��1��6z   ��6   �� *
Nazwisko+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6z   �� 5)   
   $��Imiona:��6   $��1��6"   $��0��6/   �� 5*   
   $��1��6k   $��1��6x   ��6   �� *Imiona+$ PropertyChanged=� . 6x   �� 5+   
   $��Pesel:��6   $��2��6!   $��0��6.   �� 5,   
   $��2��6j   $��1��6w   ��6   �� *Pesel+$ PropertyChanged=� . 6w   �� 5-   
   $��Kod pocztowy:��6   $��3��6(   $��0��65   �� 5.   
   $��3��6p   $��2��6}   ��6   �� *KodPocztowy+$ PropertyChanged=� . 6}   5/      50      