   M S B A M L   `   `   `  ?????  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	     ? 
ResizeMode$  NoResize=?5   	    ? Title$ 
MainWindow??5	   	   $??530.769??6   $??1066.857??6.    ? DataContext 5
         Lab2.AppViewModel  5   
   5      .??5      ? -   5         ?Name$ GridMain??5       J? RenderTransformOrigin$ -0.018,-0.05&?6   .+?5   
   ?? -   5         ??Name$ ItemsControlButton??5   2   $??35.8,48,79.8,36.8q?6   $??1??6N   $??5??6^   ??6k   ?? *	Numbers+??5      ?? 5      .R?5      ? 5      ??5      ?? 5      .R?5      ??  ??Name$ button1??6   -   5        $	??100??5   .   $??50??6:   ??6F   ?? *ButtonContent+??6i   ??  ?? RelativeSource ??  ?? Mode$ FindAncestor=?	 ?? AncestorType"	 ??
 ?? Path$
 DataContext.PickCell???6?   ?? $
 ButtonContent?{?6   ?? *IsPush+6=  5      5      ?? 5   
   -   5         ??Name$ TextBoxRule??5      $??10,438,206.6,0q?6'    ?? TextWrapping$
 Wrap=?6?   $??26??6S   $	??Top=?6_   6w   ?? 5   
   -   5         ??Name$ Label??5      $=??7Введите количество кнопок (1-40)??6   $??Right=?6J   $??0,407,132,0q?6f   $??26??6{   $	??Top=?6?   $	??222??6?   ?? 5   
   -   5        $ StartButton??5      $??Начать игру??6&   $??Right=?6<   $??
0,437,27,0q?6X   $	??Top=?6l   $	??104??6?   $??27??6?   ??6?   ??  ?? ElementName$ TextBoxRule??$

 Text???6?   ?? *	StartGame+?? 5   
   -   5        $ LabelUserMoves??5      $$??Кнопок загадано:??6(   $
??Left=?6C   $??	59,49,0,0q?6^   $	??Top=?6q   $ -2.333,1.125&?6?   $	??182??6?   ?? 5    
   -   5        $ AmountOfButtons??5       $?? ??6)   $
??Left=?64   $??59,0,0,394.8q?6O   $??Bottom=?6e   $ -7.417,-0.5&?6?   $	??238??6?   ?? 5!   
   -	   5         ??Name$ UserMoveCounter??5!      $??Right=?6+   $	??132??6G   $??0,144,209,0q?6T   $	??Top=?6i   $??86??6?   ??6?   ?? *
NumHistory+?? 5"   
   $??Запись ходов:??6   $
??Left=?6(   $??
59,113,0,0q?6C   $	??Top=?6W    ? ColumnDefinitions 5#   
   ?? 5$      $??1* ?6   ?? 5%      $??2* ?6   5'      5(      