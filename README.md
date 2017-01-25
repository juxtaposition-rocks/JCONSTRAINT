# JCONSTRAINT

A SILENT ALTERNATIVE TO TALKING OUT LOUD

## Intro

"J" stands for "journal", though JCONSTRAINT is meant to more of an alternative to journaling rather than a kind of journaling software. "Constraint" comes from the "constraints are liberating" idea from the Ruby on Rails crowd. The lack of features is considered a feature because it focuses you on what matters.

Why is journaling so useful and so highly recommended and such a thing you should do? It's a means to an end: decompressing all the pressure building up in your head. Talking to your friends can be thought of as a form of journaling... or an as alternative to journaling. That's a lot like what JCONSTRAINT is all about.

We go straight to the source. How did Jesus journal? He didn't. (Nobody did in those days. It just wasn't practical.) How did Jesus journal? He got out in the wilderness and talked to his father God directly. Why out in the wilderness? Of course it was because he was talking out loud and it was a private conversation. ;-)

For many people, it's hard to find a good time and place to have a private conversation with God out loud. The reason why JCONSTRAINT is described as A SILENT ALTERNATIVE TO TALKING OUT LOUD is because that's all it really is. It lets you type instead of talking, so that all you need is a small degree of visual isolation--not a large degree of audio isolation.

## Features

The main feature of JCONSTRAINT is its keyboard layout. (Some might argue that the keyboard layout is its ONLY feature--if you don't consider the "constraints" as features...)

JCONSTRAINT basically takes the non-ergonomic keyboard built into your laptop (or whatever you're using) and makes it a little more ergonomic by allowing your right hand to move one key to the right and by making the only usable keys within easy reach. To do this it takes away your ability to type lower-case letters, many lesser-used punctuation/symbol characters, and even carriage returns. You cannot cursor back through what you've already typed, and JCONSTRAINT even takes away your ability to delete or "backspace" characters!

Another key feature of the layout is that no key positions are shared between it and QWERTY. This makes it easier to learn and get fast at using it without sabotaging your ability to use your keyboard normally.

Rather than replicate the layout in this README, i will refer you straight to the source code file to look at it. It's plainly visible there already. (Also, it may change slightly in the future... or you may want to modify it.) An important thing to know, though, is that while the "home row" keys are what you would expect on the right hand (all in an actual row: E H T R), on the left hand the "home row" is O I N D, meaning that the home positions of the ring finger and middle finger are one row higher than that of the other two fingers.

Now, because the right hand is meant to be positioned one key to the right of "normal", JCONSTRAINT has you press the "E" character 3 times after startup before accepting any other input so that you are sure you have your right hand in the right place.

Pressing the spacebar multiple times in a row prints some fancy symbols. This makes a good alternative to a carriage return.

That's pretty much it. Output is printed to the console window and will not be saved to a file. (If you want to save anything, you will need to use "copy and paste" and a separate app of some sort.)

## Appendix: How the keyboard layout was chosen.

On my laptop (and on many keyboards), there is a number pad on the right, and so the regular part of the keyboard is left-of-center. Thus when using my laptop, my left arm is extended a little more, and my right hand is folded in a little more. (Also, my fingers are pretty long. Sorry if yours are not.) This arm position plus (of course) they asymmetry of the standard QWERTY layout itself, including the weird slant to the columns, explains the asymmetric shape of the JCONSTRAINT layout.

As for which keys are where: I built up a corpus of carefully-selected text that mostly included past writings of mine from journal entries, dream writeups, and prayers, plus a few short selections from the Bible, song lyrics, etc. I made a genetic algorithm runner that judged the quality of a layout based on how much effort it would take to type the whole corpus based on individual key weights plus two-key combination weights. I then also used a "refining" mode that took the layouts found by the genetic algorithm and ensured a true "local maximum" had been found. After using this process to select a layout, that layout was still refined further by hand after using it.

Here's the distribution of character frequencies in my corpus, each as a percentage of the frequency of E.

    = 0.0021751424718319
    ~ 0.0130508548309914
    > 0.0174011397746552
    # 0.0261017096619829
    + 0.0304519946056467
    $ 0.0391525644929743
    & 0.0761299865141167
    9 0.121807978422587
    @ 0.17183625527472
    4 0.200113107408535
    6 0.21751424718319
    8 0.21751424718319
    5 0.245791099317005
    7 0.258841954147997
    * 0.263192239091661
    ; 0.289293948753643
    3 0.334971940662113
    / 0.532909905598817
    ! 0.595989037281942
    Q 0.602514464697438
    Z 0.689520163570714
    2 0.739548440422848
    1 0.841780136598947
    0 1.08974637838778
    : 1.1114978031061
    X 1.21155435681037
    ? 1.85539652847262
    - 2.09466220037412
    J 2.16209161700091
    ( 2.3382781572193
    ) 2.3796058641841
    " 3.24748771044503
    ' 5.99686779484056
    K 9.19215208596163
    , 9.43141775786314
    V 9.46404489494062
    B 13.0443294035759
    P 14.8736242223866
    . 16.1526079958237
    F 17.8470439813808
    C 18.3081741854091
    W 20.8835428720581
    Y 20.9553225736286
    G 22.0015661025797
    M 23.822160351503
    U 25.7341105842433
    D 31.3873058685344
    L 36.7990603384522
    H 46.3022577978858
    R 47.1027102275199
    S 52.1881933266629
    N 57.8566146082568
    A 65.1085396093444
    I 66.0438508722321
    O 71.3011702266498
    T 80.0517683908296
    E 100
      196.328359507548 (Space character)

And here are the top 50 pairs (pairs with the space character were not counted):

    OW: 1653
    US: 1687
    RI: 1725
    OT: 1734
    WA: 1802
    RO: 1851
    UT: 1920
    EL: 1954
    OM: 1970
    NT: 2023
    NE: 2055
    HO: 2075
    YO: 2079
    WH: 2095
    NO: 2112
    OF: 2142
    SO: 2154
    BE: 2212
    ED: 2318
    SE: 2385
    LI: 2460
    AS: 2520
    LE: 2521
    TI: 2547
    AR: 2599
    TE: 2646
    AL: 2805
    EA: 2888
    ES: 3028
    ST: 3083
    HI: 3167
    IS: 3286
    VE: 3317
    EN: 3432
    ME: 3581
    TO: 3686
    IT: 3799
    OR: 3964
    ND: 3977
    ON: 4303
    AT: 4322
    HA: 4448
    NG: 4767
    RE: 5160
    OU: 5232
    AN: 5484
    ER: 5556
    HE: 7502
    IN: 8400
    TH: 11150
