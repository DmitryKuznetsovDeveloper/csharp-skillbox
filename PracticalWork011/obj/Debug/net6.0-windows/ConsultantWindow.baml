   M S B A M L   `   `   `  ����K  GPracticalWork011, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PracticalWork011PracticalWork011  5   	   '    !PracticalWork011.ConsultantWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PracticalWork011     5   	     � Title$  
Consultant��5   	   $	��600��6   $
��1200��6,   $	��600��6<   $
��1200��6L   .��5	      � .+�5
   
   �� -   5         ��Name$ ListClients��5
      $��450,0,10,10q�6(    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 40��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��Фамилия��6%   $ 80��66    6A   �� *Client.SecondName+�� 5      $��Имя��6%   $ 80��62    6=   �� *Client.Name+�� 5      $��Отчество��6%   $ 80��67    6B   �� *Client.Surname+�� 5      $��Телефон��6%   $	 100��66    6B   �� *Client.Phone+�� 5      $��Паспорт��6%   $	 100��66    6B   �� *Client.PassportConsultant+�� 5      $/��)Дата и время изменений��6%   $	 150��6E    6Q   �� *DateTimeEntryWasAdded+�� 5      $��Сотрудник��6%   $	 100��68    6D   �� *
ChangeInfo+5      5      �� 5   
   -   5         ��Name$ TextNewPhone��5      $
��Left=�6(   $��
40,100,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��200��5      $��20��6   $��16(�6*   $��Center=�68   $��Arial Black)�6Z   ��5      ��  �� ElementName$ ListClients�� �� Path$ SelectedItem.Client.Phone��� 5   
   $.��(Введите новый телефон��6   $
��Left=�60   $��	40,50,0,0q�6K   $	��Top=�6^   $	��247��6v   $��40��6�   $��16(�6�   $��Center=�5      $��Arial Black)�62   �� 5   
   -   5        	 ��Name$	 ButtonUpdatePhone��5      $��Изменить��6,   $
��Left=�6?   $��
40,200,0,0q�6Z   $	��Top=�6n   $	��250��5      $��50��6   $��24(�6*   $��Segoe UI Black)�68   6T   �� 5   
   -   5        
 ��Name$
 ID��5      $
��Left=�6   $��
40,150,0,0q�67   $	��Top=�6K   $��35��6c   $��40��6n   $��16(�6z   $��Center=�5       $��Center=�62   $��Arial Black)�6V   $	��ID:��6o   �� 5!   
   -   5        $
 InfoID��5!      $
��Left=�6    $��
75,150,0,0q�6;   $	��Top=�6O   $��77��6g   $��40��6r   $��16(�6~   $��Center=�5"      $
��Left=�62   $��Arial Black)�6T   ��6m   �� $ ListClients��$ SelectedItem.Id�5#      5$      