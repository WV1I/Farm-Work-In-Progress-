   M S B A M L   `   `   `  ����?  ;Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Farm.Farma.KontrolkiFarm.Farma.Kontrolki  5      G(clr-namespace:Farm.Farma.Klasy.ViewmodelFarm.Farma.Klasy.Viewmodel  5           Farm.Farma.Kontrolki.Login   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Farm.Farma.Kontrolki     5      ?
viewmodels(clr-namespace:Farm.Farma.Klasy.Viewmodel     5      .��5      �   � RowDefinitions  5   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��5* �6   6,   .+�5   
   �� $��0��6   $��1��6   $��10,30,10,30q�6/   $��36(�6D   ��6R   �� *LoginViewModel.Username+ �� Mode$ TwoWay=�6�   G� 5   
   -   5        $��PasswordInput��5      $��1��6+   $��1��68   $��10,30,10,30q�6H   $��36(�6]   �� 5   
   $��0��6   $��0��6   $��Login:��6-   $$��Bahnschrift SemiBold Condensed)�6>   $
��Bold"�6j   $��
0,30,20,30q�6|   $��36(�6�   �� 5   
   $��1��6   $��0��6   $��Hasło:��6-   $$��Bahnschrift SemiBold Condensed)�6>   $��36(�6j   $
��Bold"�6x   $��
0,30,20,30q�6�   �� 5   
   $��2��6   $��Arial Black)�6M   $��18(�6f   $
��Bold"�6t   
���  ��$��1��6�   $��Center=�6�   $��
0,10,25,10q�6�   ��6   �� *LoginViewModel.LoginMessage+6�   �� 5   
   $��1��6   $��2��6!   $��Zaloguj��6.   $��	0,10,0,10q�6�   $��90��6�   $��Right=�6�   ��6@   ��  �� ElementName$ PasswordInput����6w   �� *LoginViewModel.LoginCommand+6�   �� 5   
   $��2��6   $��Zarejestruj��6   $
��Left=�64   $��	0,10,0,10q�6�   $��90��6�   ��6O   �� $ PasswordInput����6�   �� * LoginViewModel.RegisterCommand+6�   5       5!      