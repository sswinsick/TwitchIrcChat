   M S B A M L   `   `   `  ����   TwitchIrcChat    TwitchIrcChat.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  	TwitchIRC��$	��300��$	��420�� � WindowState$ Normal=� � 
ResizeMode$ 	CanResize=�$��Bottom=�$��Center=�$
��Left=�$��Center=�$	��400��$	��200��.��� .+��� -   $��
image_test��$
��Left=�$��349,366,0,80q�$
��Fill=�$��0���� -   $��textBox1��$��25��$��Stretch=�$��Bottom=�$
��Auto��}�. $��Stretch=�$��Stretch=�� -   $��grid1��$
��Auto��$��Stretch=�$��	0,73,0,30q�$��Stretch=�$
��Auto��}�.  J� 	AllowDrop .   � RowDefinitions �� $��* �.+��� -   $��Text_UserList��
���   �$	��100��}�. $��Right=� �� 
IsReadOnly . 
��������� -    ��Name$ 
TabControl��$��Stretch=�$��	0,0,100,0q�$
��Auto��   TabControlControlTemplate1#���   $ �� IsSynchronizedWithCurrentItem$
 TrueY�$��Stretch=�$
��Auto�� � 	Resources    TabScrollerRepeatButtonStyle	 �� 
TargetType
 �� Property �� Value �� 
TargetType �Name-  'System.Windows.Input.KeyboardNavigation   TabNavigation � ColumnDefinitions ��Name ��Name ��Name   TabIndex   DirectionalNavigation ��Name �� SelectedContent �� SelectedContentTemplate& �� SelectedContentTemplateSelector � DataContext ��Name K� IsItemsHost �� Orientation��%<  &	       &	  �     �� "	 ��.��� 
 � �� �� .R��� 0���)sc#1, 0.366693377, 0.372125238, 0.6931424._��� $��Center=�$��Center=�#��z���� " ��.R�� $
 Grid��$ Local=� �� $ ColumnDefinition0���� $ ColumnDefinition1��$��0 � �� $ RowDefinition0��$
��Auto ��� $ RowDefinition1��$��* �.+��� $ ContentPanel��$��1��$��0�����	#FFD0CEBF$��0,0,0,0q�$ 0��$ Local=�$ 	Contained=�._��� $ Border��#��z��#��z��._��� $ Border1��#��z��._��� $ PART_SelectedContentHost��#��z��#��z #��z #��z $��SelectedContent�� Z� �� $ HeaderPanel��$��0��$��0��$��Stretch=�$��Stretch=�$��0,0,0,0q�$��Hidden=�$��Disabled=����� "	 ��.��� 
 � �� �� .R�� $ HeaderPanel��$��0,0,0,0q�$��0��$��0��
���   � �� $��25 ��� $��* ��� $��25 � �� $
��Auto �.+��� $��0��$��<��$��ScrollBar.LineLeftCommand��#���  �� $��1��#��z���� $��2��$��>��$ ��ScrollBar.LineRightCommand��#���  .����  . $ 
Horizontal=�$ 1����Z� .@��� -    ��Name$ 	ServerTab��$��Server��.���� -    ��Name$ ServerChatArea��
���   �$��15(� �� IsDocumentEnabled . "  �� VerticalScrollBarVisibility$  Visible=� ��%3   'J�       �� "	 J�.��� 
 �@��Margin$ 0q��� -	   $��
textBlock1��$��18��$
��Left=�$��	Username:��$	��Top=�$��62���� -
   $��	text_user��$��19��$
��Left=�$��68,0,0,0q�$	��Top=�$��72���� -   $��
textBlock2��$��17��$
��Left=�$��1,52,0,0q�$��	Password:��$	��Top=�$��93���� -   $��
textBlock3��$��19��$
��Left=�$��1,25,0,0q�$��Channel:��$	��Top=�$��76���� -   $��	text_chan��$��19��$
��Left=�$��	68,25,0,0q�$	��Top=�$��72���� -   $��button_join��$
��Join��$��18��$
��Left=�$��
159,50,0,0q�$	��Top=�$��58��!   	IsTabStop! .  �� -   $��button_part��$
��Part��$��18��$
��Left=�$��
223,50,0,0q�$	��Top=�$��55��! .  �� -   $��Button_Connect��$��Connect��$��18��$
��Left=�$	��Top=�$��
159,25,0,0q�$��58��G� -   $��	text_pass��$��19��$
��Left=�$��	68,52,0,0q�$	��Top=�$��72���� -   $��Button_Clear��$��
Clear Text��$��18��$
��Left=�$��
284,50,0,0q�$	��Top=�$��72��! .  �� -   $��
RememberMe��$��Remember Me��$��19��$
��Left=�$��	159,1,0,0q�$	��Top=�$	��125���� -   $��Config��$
��Left=�$��
223,25,0,0q�$	��Top=�$��75��$��18��