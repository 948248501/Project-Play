# Project Play
# 
# This project enables users to create and play music on their computer.

# FILE: project_play.rb

require 'audite' # Load the Audite library for playing music

# Create a new audio player instance
player = Audite.new

# Create an array of files
files = ['song1.mp3', 'song2.mp3', 'song3.mp3', 'song4.mp3']

# Loop through each file and add it to the audio player
files.each do |file|
 player.load(file)
end

# Play the audio
player.play()

# Main menu loop
loop do
 # Show the main menu
 puts "Select an option:"
 puts "1) Play Music"
 puts "2) Next Track"
 puts "3) Previous Track"
 puts "4) Stop Music"
 puts "5) Set Volume"
 puts "6) Exit"
 
 # Get user input
 input = gets.chomp # Read the user input
 
 # Process the input
 case input
 when "1"
  # Play the music
  player.play
 when "2"
  # Go to the next track
  player.forward
 when "3"
  # Go to the previous track
  player.rewind
 when "4"
  # Stop the music
  player.stop
 when "5"
  # Get the user input for the volume level
  puts "Enter a new volume level (0-100):"
  volume = gets.chomp.to_i
  
  # Set the volume
  player.set_volume(volume)
 when "6"
  break # Exit the loop
 else
  puts "Invalid input"
 end
end

# Cleanup
player.stop
player.close