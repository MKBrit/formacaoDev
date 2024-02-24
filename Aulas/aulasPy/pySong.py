import winsound
for freq in range(100, 1000, 10):
    # Note: 500 is duration, in millis
    winsound.Beep(freq, 500)