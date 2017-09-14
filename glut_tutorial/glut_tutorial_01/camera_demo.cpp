#include "camera_demo.h"
#include <gl/glm/glm.hpp>
#include <GL/glm/gtc/matrix_transform.hpp>
#include <GL/glm/gtc/type_ptr.hpp>
#include <math.h>


camera_demo::camera_demo(const glm::vec3 &pos, const glm::vec3 &vec_front,
						 const glm::vec3 &vec_up, const float &speed)
{
	cam_pos = pos;
	cam_up = vec_up;
	cam_front = vec_front;
	cam_speed = speed;
	cam_pitch = default_cam_pitch;
	cam_yaw = default_cam_yaw;
	cam_roll = default_cam_roll;
}


camera_demo::~camera_demo()
{
}

void camera_demo::move(const int &mode, const float &value)
{
	switch (mode)
	{
	case 3:
	{
		cam_pos += value * cam_front;
		break;
	}
	case 4:
	{
		cam_pos -= value * cam_front;
		break;
	}
	case 1:
	{
		cam_pos += value * glm::normalize(glm::cross(cam_up, cam_front));
		break;
	}
	case 2:
	{
		cam_pos -= value * glm::normalize(glm::cross(cam_up, cam_front));
		break;
	}
	}
}

void camera_demo::look(const float &pitch_val, const float &yaw_val, const float &roll_val)
{
	cam_pitch += pitch_val;
	if (cam_pitch > 89.0f)
		cam_pitch = 89.0f;
	if (cam_pitch < -89.0f)
		cam_pitch = -89.0f;
	cam_yaw += yaw_val;
	cam_roll += roll_val;
}

void camera_demo::set(const int &mode, const float &value)
{
	if (mode == 4)
		cam_speed = value;
}

void camera_demo::set(const int &mode, const glm::vec3 &vec)
{
	switch (mode)
	{
	case 1:
	{
		cam_pos = vec;
		break;
	}
	case 2:
	{
		cam_front = glm::normalize(vec);
		break;
	}
	case 3:
	{
		cam_up = glm::normalize(vec);
		break;
	}
	}
}

glm::mat4 camera_demo::view_mat()
{
	glm::vec3 front;	// Set the value of camera-front vector 
	front.x = cos(glm::radians(cam_pitch)) * cos(glm::radians(cam_yaw));
	front.y = sin(glm::radians(cam_pitch));
	front.z = cos(glm::radians(cam_pitch)) * sin(glm::radians(cam_yaw));
	cam_front = glm::normalize(front);
	view_matrix = glm::lookAt(cam_pos, cam_pos + cam_front, cam_up);
	return view_matrix;
}