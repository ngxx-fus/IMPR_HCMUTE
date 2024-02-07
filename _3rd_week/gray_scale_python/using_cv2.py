import cv2
import numpy as np

img_path = r"D:/DOC/23-24_HK02/IMPR/ngxx_fus.jpg"

img = cv2.imread(img_path)

cv2.imshow("Original", img)

gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

cv2.imshow("Grayscale", gray)
cv2.waitKey(0)
cv2.destroyAllWindows()


