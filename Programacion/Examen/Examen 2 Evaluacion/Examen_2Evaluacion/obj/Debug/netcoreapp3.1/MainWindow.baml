   M S B A M L   `   `   `  ����M  IExamen_2Evaluacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Examen_2EvaluacionExamen_2Evaluacion  5   	   #    Examen_2Evaluacion.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Examen_2Evaluacion     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ 	principal��5	      .+�5
   
   o� $��	0,0,0,375q�6   .@�5      m� -   5         m�Name$ menu_alta_distribuidor��5      $��Alta distribuidor��67   $��32��6R   6^   m� 5      -   5        $ 
menu_datos��5      $��Datos��6+   $��32��6:   6F   m� 5      -   5        $ 
menu_salir��5      $��Salir��6+   $��32��6:   6F   5      �� 5   
   -   5         ��Name$ altas_ambos��5      $y�Visible=�6*   $��40,75,75,75q�6?   .@�5      �� -   5         ��Name$ tb_alta_distribuidor��5      $��Alta distribuidores��64   .��5      � -   5        $ alta_distribuidores��5      ���	#FFE5E5E5.+�5      �� -   5         ��Name$ 
lbl_nombre��5      $��	Nombre*: ��60   $
��Left=�6D   $��	40,34,0,0q�6_   $	��Top=�6r   �� 5      -	   5        $ lbl_primer_apellido��5      $��Primer_apellido*:  ��69   $
��Left=�6W   $��	40,83,0,0q�6r   $	��Top=�6�   �� 5      -
   5        $ lbl_telefono1��5      $��Telefono1*:  ��63   $
��Left=�6K   $��
40,128,0,0q�6f   $	��Top=�6z   �� 5      -   5        $ lbl_telefono2��5      $��Telefono2:  ��63   $
��Left=�6J   $��
40,171,0,0q�6e   $	��Top=�6y   �� 5      -   5        $ lbl_correo_electronico��5      $��Correo Electronico*: ��6<   $
��Left=�6\   $��
366,34,0,0q�6w   $	��Top=�6�   �� 5      -   5        $ lbl_direccion��5      $��Direccion*:��63   $
��Left=�6I   $��
366,83,0,0q�6d   $	��Top=�6x   	� 5      -   5         	�Name$ 
rb_cliente��5   "   $��Cliente��66   $
��Left=�6H   $��509,129,0,0q�6c   $	��Top=�6x    	� 	GroupName$ cliente/distribuidor��6�   6�   	� 5      -   5        $ rb_distribuidor��5   "   $��Distribuidor��6;   $
��Left=�6R   $��509,149,0,0q�6m   $	��Top=�6�   $ cliente/distribuidor��6�   6�   �� 5      -   5        $ lbl_cliente_distribuidor��5      $��Cliente/Distribuidor*:��6>   $
��Left=�6_   $��366,129,0,0q�6z   $	��Top=�6�   �� 5      -   5         ��Name$ cbx_provincia��5      $
��Left=�66   $��509,197,0,0q�6Q   $	��Top=�6f   $	��120��6~   ${�False��6�   �� 5      -   5        $ lbl_provincia��5      $��Cliente/Distribuidor*:��63   $
��Left=�6T   $��363,193,0,0q�6o   $	��Top=�6�   �� 5      -   5        	 ��Name$	 btn_aceptar��5      $��Aceptar��62   $
��Left=�6D   $��
33,210,0,0q�6_   $	��Top=�6s   6�   �� 5      -   5        $	 btn_cancelar��5      $��Cancelar��63   $
��Left=�6F   $��118,206,0,0q�6a   $	��Top=�6v   6�   �� 5       -   5        
 ��Name$
 
txt_nombre��5       $
��Left=�62   $��
142,38,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5!      -   5        $
 txt_primer_apellido��5!      $
��Left=�6;   $��
141,87,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5"      -   5        $
 txt_telefono1��5"      $
��Left=�65   $��141,132,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   6�   �� 5#      -   5        $
 txt_telefono2��5#      $
��Left=�65   $��141,175,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   6�   �� 5$      -   5        $
 txt_correo_electronico��5$      $
��Left=�6>   $��
509,34,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5%      -   5        $
 txt_direccion��5%      $
��Left=�65   $��
509,87,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   5&      5'      5(      �� 5)   
   -   5        $ datos_ambos��5)      $y�Hidden=�6*   $��68,94,53,41q�6>   .@�5*      �� -   5        $ 
tb_cliente��5*      $��Cliente��6*   .��5+      � -   5        $ 	g_cliente��5+      ���	#FFE5E5E56*   5,      �� 5-      -   5        $ tb_distribuidor��5-      $��Dsitribuidor��6/   .��5.      � -   5        $ g_distribuidor��5.      ���	#FFE5E5E56/   5/      50      51      52      