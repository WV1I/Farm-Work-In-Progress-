   M S B A M L   `   `   `  ����?  ;Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FarmFarm  5   	   ;"clr-namespace:Farm.Farma.KontrolkiFarm.Farma.Kontrolki  5   	   1clr-namespace:Farm.Farma.OknaFarm.Farma.Okna  5   	   G(clr-namespace:Farm.Farma.Klasy.ViewmodelFarm.Farma.Klasy.Viewmodel  5
   	       Farm.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Farm     5   	   7controls"clr-namespace:Farm.Farma.Kontrolki     5   	   1windowsclr-namespace:Farm.Farma.Okna     5   	   ?
viewmodels(clr-namespace:Farm.Farma.Klasy.Viewmodel     5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5      .   (Farm.Farma.Klasy.Viewmodel.MainViewModel  5   
   6%    � 	Resources 5         LoginScreen �� DataType    Farm.Farma.Kontrolki.Login  
GameScreen#   Farm.Farma.Kontrolki.MainGame��%�   &	        &	 e     �� 5   
   "  6+   .R�5        $��0��6   $��Stretch=�6.   $��Stretch=�6L   5      �� 5   
   "  6*   .R�5        6"   5      5      .��5      �  � ColumnDefinitions 5   
   .+�5   
   �� ��6   �� ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value# [  68    �� Triggers 5       �� 5!      	 �� Binding	 6&   �� *LoginViewModel.IsLogged+
 �� Value
 True6R   .a�5"      ��  � ��# [ 6@   5#      5%      5'      5)      5*      