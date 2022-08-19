10 frames
two opportunities to knock down 10 pins
score = total number of pins knocked down plus bonuses

spare - all 10 pins downed in 2 tries
bonus for spare = is the number of pins knocked down by the next roll

strike - all 10 pins down in 1 frame
bonus for strike = sum of two next rolls

at 10 frame, if there is spare or strike, 
player allowed to roll extra balls but no more than 3

Game has two methods 
roll(int pins) - called each time player rolls a ball. 
Argument is number of knocked down pins.
score() - called at the end of the game. Returns total score for that game