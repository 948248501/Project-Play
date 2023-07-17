%This m-file is designed to produce an interactive game based on the classic game of Jenga.

%Clear the workspace

clear all;

%Set the game difficulty level

difficulty = input('Choose the difficulty level [easy, medium, hard]: ');

%Define game variables

score = 0; %score, starts at 0
lives = 3; %number of lives, starts at 3

%Graphics setup

Hf = figure;
set(Hf, 'name', 'Project Play: Jenga');
axes('position', [0 0 1 1]);
set(gca, 'xtick', [], 'ytick', [])
box on;

%Game rules

disp('Game rules: To win the game, remove blocks without making the tower fall within')
disp('3 lives. If the tower falls, you lose 1 life, and the game starts over')

%Game loop

playAgain = 'yes';
while strcmp(playAgain, 'yes') == 1
   
    %Start the game
    
    disp('Starting game...')
    
    %Set up the tower design
    
    %Easy mode:
    if strcmp(difficulty, 'easy') == 1
        blocks = [1 0 0 1; 1 0 0 1; 1 0 0 1; 1 0 0 1; 1 0 0 0;];
    end
    
    %Medium mode:
    if strcmp(difficulty, 'medium') == 1
        blocks = [1 0 0 0; 1 0 0 1; 1 0 0 1; 1 0 0 1; 1 0 0 1;];
    end
    
    %Hard mode:
    if strcmp(difficulty, 'hard') == 1
        blocks = [0 0 0 0; 1 0 0 1; 1 0 0 1; 1 0 0 1; 1 0 0 1;];
    end
    
    %Draw the tower
    for c = 1:size(blocks,1)
        if blocks(c,1) == 1
            rectangle('position', [0.2+(c-1) 0.2+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
        end
        if blocks(c,2) == 1
            rectangle('position', [0.2+(c-1) 0.8+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
        end
        if blocks(c,3) == 1
            rectangle('position', [0.8+(c-1) 0.2+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
        end
        if blocks(c,4) == 1
            rectangle('position', [0.8+(c-1) 0.8+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
        end
    end
    
    %Gameplay loop
    
    while sum(blocks(:)) ~= 0 && lives > 0
        
        %Display instructions & number of lives
        
        disp('Select which block to remove (1,2,3,4): ')
        disp(['Lives: ' num2str(lives)])
        
        %Draw the tower
        
        for c = 1:size(blocks,1)
            if blocks(c,1) == 1
                rectangle('position', [0.2+(c-1) 0.2+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
            end
            if blocks(c,2) == 1
                rectangle('position', [0.2+(c-1) 0.8+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
            end
            if blocks(c,3) == 1
                rectangle('position', [0.8+(c-1) 0.2+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
            end
            if blocks(c,4) == 1
                rectangle('position', [0.8+(c-1) 0.8+(c-1) 0.6 0.6], 'facecolor', [1 0.2 0], 'edgecolor', 'k');
            end
        end
        
        %User input for which block to remove
        
        blockChoice = input('Choose a block to remove: ');
        
        %Check if the tower will fall
        
        fallStatus = checkTower(blocks, blockChoice);
        
        %If the tower will fall
        
        if fallStatus == 1
            lives = lives - 1;
            disp('Oh no! The tower has fallen!')
            disp(['Lives left: ' num2str(lives)])
        else
            %If the tower will not fall
            score = score + 1;
            disp('Good job! You can remove this block.')
            disp(['Score: ' num2str(score)])
        end
        
        %Update the blocks
        blocks(blockChoice, :) = 0;
    end
   
    %If the tower has fallen 3 times
    if lives == 0
        disp('Game over!')
    end
    
    %If all the blocks have been removed
    if sum(blocks(:)) == 0
        disp('You win!')
    end
    
    %Prompt the user to play again
    playAgain = input('Would you like to play again? [yes/no] ');
    
    %Reset lives and score
    lives = 3;
    score = 0;
end