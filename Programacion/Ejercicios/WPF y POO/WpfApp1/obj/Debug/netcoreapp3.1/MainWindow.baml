   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Práctica3SolucionPráctica3Solucion  5   	   #    Práctica3Solucion.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Práctica3Solucion     5   	     � Title$  
Formulario��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ 	principal��5	      .+�5
   
   �� -   5         ��Name$ 	txtNombre��5
       �� 	MaxLength$ 32��6%   $
��Left=�64   $��
115,77,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��210��6�   6�   �� 5   
   -   5         ��Name$ 	lblNombre��5      $��Nombre*��6#   $
��Left=�65   $��
115,46,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ lblApellido1��5      $��Primer apellido*��6&   $
��Left=�6A   $��115,107,0,0q�6\   $	��Top=�6q   �� 5   
   -   5        $ txtApellido1��5      $ 32��6(   $
��Left=�67   $��115,138,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��210��6�   6�   �� 5   
   -   5        $ lblTelefono1��5      $��Teléfono 1*��6&   $
��Left=�6<   $��115,275,0,0q�6W   $	��Top=�6l   �� 5   
   -   5        $ lblTelefono2��5      $��Teléfono 2��6&   $
��Left=�6;   $��225,275,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ txtTelefono1��5      $ 9��6(   $
��Left=�66   $��115,306,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��90��6�   6�   �� 5   
   -	   5        $ txtTelefono2��5      $ 9��6(   $
��Left=�66   $��225,306,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��90��6�   6�   �� 5   
   -
   5        $ lblApellido2��5      $��Segundo apellido��6&   $
��Left=�6A   $��115,168,0,0q�6\   $	��Top=�6q   �� 5   
   -   5        $ txtApellido2��5      $ 32��6(   $
��Left=�67   $��115,199,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��210��6�   	� 5   
   -   5         	�Name$ 	rbCliente��5      $��Cliente��6)   $
��Left=�6;   $��129,244,0,0q�6V   $	��Top=�6k    	� 	GroupName$
 Tipo��6�   6�   	� 5   
   -   5        $ rbDistribuidor��5      $��Distribuidor��6.   $
��Left=�6E   $��217,244,0,0q�6`   $	��Top=�6u   $
 Tipo��6�   6�   �� 5   
   -   5        $ lblEmail��5      $��Correo electrónico*��6"   $
��Left=�6@   $��
366,46,0,0q�6[   $	��Top=�6o   �� 5   
   -   5        $ txtEmail��5      $	 100��6$   $
��Left=�64   $��
366,77,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��210��6�   6�   �� 5   
   -   5        $ lblDireccion��5      $��Dirección*��6&   $
��Left=�6;   $��366,107,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ txtDireccion��5      $	 100��6(   $
��Left=�68   $��366,138,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��210��6�   6�   �� 5   
   -   5        $ 	lblPostal��5      $��Código Postal*��6#   $
��Left=�6<   $��366,168,0,0q�6W   $	��Top=�6l   �� 5   
   -   5        $ 	txtPostal��5      $ 5��6%   $
��Left=�63   $��366,199,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $��80��6�   6�   �� 5   
   -   5        $ lblPoblacion��5      $��Población*��6&   $
��Left=�6;   $��369,226,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ txtPoblacion��5      $ 32��6(   $
��Left=�67   $��369,257,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��210��6�   6�   �� 5   
   -   5        $ lblProvincia��5      $��
Provincia*��6&   $
��Left=�6;   $��471,163,0,0q�6V   $	��Top=�6k   �� 5   
   -   5         ��Name$ 	btnEnviar��5      $��Enviar��6$   $
��Left=�65   $��234,381,0,0q�6P   $	��Top=�6e   $��70��6}   $��25��6�   ${�False��6�   6�   �� 5    
   -   5        $ btnCancelar��5       $��Cancelar��6&   $
��Left=�69   $��396,381,0,0q�6T   $	��Top=�6i   $��70��6�   $��25��6�   6�   5!      5"      