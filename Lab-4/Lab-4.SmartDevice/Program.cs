using Lab_4.SmartDevice.Entites;

var light = new Light();
light.TurnOn();
light.ShowStatus();

var thermostat = new Thermostat();
thermostat.TurnOn();
thermostat.ShowStatus();

var camera = new SecurityCamera();
camera.TurnOn();
camera.ShowStatus();