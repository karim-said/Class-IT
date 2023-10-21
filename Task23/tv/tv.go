package tv

import "fmt"

type TV struct {
	Name      string
	Status    bool
	InputMode InputMode
	Tuner     Tuner
	Channel   Channel
	Volume    int
}

type InputMode struct {
	Name string
}

type Tuner struct {
	Name  string
	Model string
}

type Channel struct {
	Number int
	Name   string
}

func (t *TV) On() {
	t.Status = true
	fmt.Printf("TV включен\n")
}

func (t *TV) Off() {
	t.Status = false
	fmt.Printf("TV выключен\n")
}

func (t *TV) Mute() {
	t.Volume = 0
	fmt.Printf("Включен режим без звука\n")
}

func (t *TV) VolumeUp() {
	if t.Volume < 100 {
		t.Volume++
	}
	fmt.Printf("Громкость: %d\n", t.Volume)
}

func (t *TV) VolumeDown() {
	if t.Volume > 0 {
		t.Volume--
	}
	fmt.Printf("Громкость: %d\n", t.Volume)
}

func (t *TV) ChangeInput() {
	fmt.Printf("Введите число для выбора: \n " +
		"1 - HDMI\n " +
		"2 - VGA\n " +
		"3 - USB\n ")
	var inputMode InputMode
	var inputNumber int
	fmt.Scan(&inputNumber)
	switch inputNumber {
	case 1:
		inputMode.Name = "HDMI"
	case 2:
		inputMode.Name = "VGA"
	case 3:
		inputMode.Name = "USB"
	default:
		fmt.Printf("Режим не найден\n")
	}
	t.InputMode = inputMode
	fmt.Printf("Переключен режим %s\n", t.InputMode.Name)
}

func (t *TV) ChangeChannel(channels []Channel) {

	for _, channel := range channels {
		fmt.Printf("%d - %s\n", channel.Number, channel.Name)
	}

	fmt.Printf("Введите номер канала\n")
	var chanNumber int
	fmt.Scan(&chanNumber)

	channelFound := false

	for _, channel := range channels {
		if channel.Number == chanNumber {
			t.Channel = channel
			fmt.Printf("Переключен канал %d - %s\n", channel.Number, channel.Name)
			channelFound = true
			break
		}
	}

	if !channelFound {
		fmt.Printf("Канал с номером %d не найден\n", chanNumber)
	}
}
