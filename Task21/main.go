package main

import "projector-class/models"

func main() {

	size := models.Size{
		Height: 1080,
		Width:  1920,
	}

	focus := models.Focus{
		FocusDistance: 100,
	}

	mode := models.Mode{
		Name: "HDMI",
	}

	proj := &models.Projector{
		Name:   "Canon",
		Size:   size,
		Focus:  focus,
		Mode:   mode,
		Status: false,
	}

	var projectorIF models.ProjectorInterface
	projectorIF = proj

	projectorIF.SetCustomSize(720, 1280)
	projectorIF.SetFocus(models.Focus{FocusDistance: 150})
	projectorIF.SetMode(models.Mode{Name: "VGA"})
	projectorIF.TurnOn()
	projectorIF.GetInfo()
}
