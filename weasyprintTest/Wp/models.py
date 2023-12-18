from django.db import models

class WashMachine(models.Model):
    name = models.CharField(max_length=100)
    state = models.BooleanField(default=False)
    mode = models.CharField(max_length=101)
    
    
    def __str__(self):
        return self.title