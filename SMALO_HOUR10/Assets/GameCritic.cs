//Improving the Game

//Legend:
// "-" -> jotted idea
// "*" -> implemented idea
// ">" -> personal though/comment
// "('text')" -> what I did to implement the idea

// Is the game too easy or hard?
// > The Game can easily complete itself - "Luigi Wins by Doing Absolutely Nothing"
// - make it so you have to stop the balls from hitting their goals
// - if a Chaosball collides with a ColoredBall, then position of the ColoredBall Resets
// What would make it easier or harder?
// * Make it so that you have to hit the balls a number of times before they can enter their goals
//     (made an additional script called "CollisionScript" that is attahced to the colored balls)
//     (whenever the bumper collides with a ball, the console will note it and count the number of bumps)
//     (when the number of bumps is at least 3, the ball can enter it's goal like normal)
//          (number of bumps was made a public int for debug purposes)
//     (this was done with a status system similar to how the GameManager checks for "isSolved")
// What would give it a "wow" factor?
// * top down view of the game
//     (camera is positioned at the top, looking down)
// * change the bumper shape
//     (replaced the bumper with a cylinder)
// What Parts of the game are fun? What parts of the game are Tedious?
// > The Character Movement is too slow compared to the balls
// * make the movement of the bumper based on the mouse location
//     (imagine the bumper is your cursor when playing)
//     (as a result, the FirstPersonCharacter is no longer needed)