import cv2          #sử dụng thư viện xử lí ảnh openCV cho python   
import numpy as np  #thư viện toán học
import sys

# Lưu đường dẫn ảnh
# img_path = "D:/DOC/23-24_HK02/IMPR/lena_color.png"
img_path = "D:/DOC/23-24_HK02/IMPR/789x480_IMG.jpg"

#Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(img_path, cv2.IMREAD_COLOR)


#Hiển thị hình dùng thư viện OPENCV
cv2.imshow('Image', img)

#Bấm phím để kết thúc   
# cv2.waitKey(0)

#Giải phóng bộ nhớ
# cv2.destroyAllWindows()
