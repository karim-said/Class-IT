package models

// Projector структура представляет модель проектора
type Projector struct {
	ID       uint   `gorm:"primaryKey"`
	Model    string `json:"model"`
	Name     string `json:"name"`
	Width    int    `json:"width"`
	Height   int    `json:"height"`
	Mode     string `json:"mode"`
	IsActive bool   `json:"is_active"`
}
