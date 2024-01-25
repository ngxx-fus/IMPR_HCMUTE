import cv2          #sử dụng thư viện xử lí ảnh openCV cho python   
from PIL import Image
import numpy as np  #thư viện toán học

#Xử lý và tính toán trên thư viện OPENCV
def gray_scale_avg_OPENCV(img):
    #tuple [L:R)
    h, w = img.shape[0:2] #h w c
    for x in range(h) : 
        for y in range(w):
            pixel = img[x][y]
            b, g, r = pixel
            avg = ( b/3+ g/3 + r/3 )
            gray_pixel = (np.uint8(avg), np.uint8(avg), np.uint8(avg))
            img[x][y] = gray_pixel
    return img

def gray_scale_avg_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    # create an image
    gray = Image.new(Original.mode, Original.size)
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )
            # avg = np.uint8(B/3+G/3+R/3)
            avg = np.uint8((R + G+ B) / 3)
            color = (avg, avg, avg)
            gray.putpixel( localtion, color)
    return gray

def gray_scale_lightness_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    # create an image
    gray = Image.new(Original.mode, Original.size)
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )
            min_val = min(B, G, R)
            max_val = max(B, G, R)
            G_val = np.uint8( (max_val + min_val)/2 )
            color = (G_val, G_val, G_val)
            gray.putpixel( localtion, color)
    return gray

def gray_scale_luminance_PILLOW(Original : Image) -> Image:
    #tuple [L:R)
    w, h = Original.size
    #create an image
    gray = Image.new( Original.mode, Original.size )
    # the gray scale processing
    for x in range(w) : 
        for y in range(h):
            localtion = (x,y)
            R, G, B = Original.getpixel( localtion )
            G_val = np.uint8( 0.3*R + 0.59*G+ 0.11*B)
            color = (G_val, G_val, G_val)
            gray.putpixel( localtion, color)
    return gray