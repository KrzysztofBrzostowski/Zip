   M S B A M L   `   `   `  ����W  SR12_Walidacja_IDataErrorInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:R12_Walidacja_IDataErrorInfoR12_Walidacja_IDataErrorInfo  5   	   -    'R12_Walidacja_IDataErrorInfo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:R12_Walidacja_IDataErrorInfo     5   	     � Title$!  Walidacja danych (wersja 4)��5   	   $	��100��6-   $	��450��6:    � Language$ pl-PL�6F    � DataContext 5	      (  "R12_Walidacja_IDataErrorInfo.Towar  5
   
      Nazwa$ ołówek��6      Cena$ 21Q�6%    � 	Resources 5       �� 
TargetType �� Property �� Value��%;  '��       �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 100��6&   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� �� 5      
���  ����6(   �� *CurrentItem.ErrorContent+6R   5      5      5      5      5      .��5      � .+�5   
   �� $��Nazwa:��6   �� 5   
   ��6   �� *Nazwa+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� ValidatesOnDataErrors
 . �� 5   
   $��Cena:��6   �� 5    
   ��6   �� *Cena+$	 PropertyChanged=� �� StringFormat$ {0:F2}��
 . 5!      5"      