# Overview <br>
My first game ever in unity which is an endless car driving game where the player has to create new highscores by avoiding the obstacles.<br>
A spawner object keeps spawning obstacles between random range of intervals which gets more difficult as time passes by.<br>
A destroyer object follows at the back of the camera and destroys the spawned obstacles. This way of object pooling is not recommended as it is very expensive on the CPU. Instead of destroying the objects, they should be disabled.<br>
The player can also choose a car of his own and the settings are stored when quitting the application.<br>
<br>
## Demo Video<br>
[![Ziggy](http://img.youtube.com/vi/41yRhWAhpzs/0.jpg)](https://www.youtube.com/watch?v=41yRhWAhpzs "Ziggy")<br>
<br>
<style type="text/css">
    .gd__aspect-ratio-box {
        position: relative;
        overflow: hidden;
        height: 0;
        /*padding-top: 56.25%; !* 16:9 Aspect Ratio *!*/
        padding-top: 75%; /* 4:3 Aspect Ratio */
        /*padding-top: 66.66%; !* 3:2 Aspect Ratio *!*/
        /*padding-top: 62.5%; !* 8:5 Aspect Ratio *!*/
    }
    .gd__aspect-ratio-box iframe {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        border-radius: 2px;
    }
</style>
<div class="gd__aspect-ratio-box">
    <iframe frameborder="0" src="https://itch.io/embed/824225?linkback=true&amp;border_width=5" width="560" height="175"><a href="https://ko8e.itch.io/endless-runner">Endless-runner by ko8e</a></iframe>
</div>
