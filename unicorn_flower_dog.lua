local ProjectPlay = {}

-- Initialize Variables 
ProjectPlay.level = 1
ProjectPlay.lives = 3
ProjectPlay.score = 0
ProjectPlay.maxScore = 0

-- Main Functions
function ProjectPlay:init()
	-- Init game here
end

function ProjectPlay:update(dt)
	-- Update game logic here 
end

function ProjectPlay:draw()
	love.graphics.print(self.score, 10, 10)
end

function ProjectPlay:keypressed(key)
	-- Handle key presses here
end

-- Helper Functions
function ProjectPlay:updateScore()
	-- Update score here
end

function ProjectPlay:updateLives()
	-- Update lives here
end

function ProjectPlay:nextLevel()
	-- Move to next level here
end

function ProjectPlay:recordMaxScore()
	-- Record the highest score here
end

-- Return namespace
return ProjectPlay