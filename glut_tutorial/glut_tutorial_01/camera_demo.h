#ifndef _CAMERA_DEMO_H
#define _CAMERA_DEMO_H

#include <gl/glm/glm.hpp>
#include <gl/glm/gtc/matrix_transform.hpp>
#include <gl/glm/gtc/type_ptr.hpp>

#define CENTER_X			0.5f
#define CENTER_Y			0.5f
#define CAM_MOV_LEFT		1
#define CAM_MOV_RIGHT		2
#define CAM_MOV_FORWARD		3
#define CAM_MOV_BACKWARD	4
#define CAM_POS				1
#define CAM_FRONT			2
#define CAM_UP				3
#define CAM_SPEED			4

// Default Values
const glm::vec3 default_cam_up		= glm::vec3(0.0f, 1.0f, 0.0f);
const glm::vec3 default_cam_front	= glm::vec3(0.0f, 0.0f, -1.0f);
const glm::vec3 default_cam_pos		= glm::vec3(0.0f, 0.0f, 3.0f);
const float		default_cam_speed	= 0.05f;
const float		default_cam_pitch	= 0.0f;
const float		default_cam_yaw		= -90.f;
const float		default_cam_roll	= 0.0f;

class camera_demo
{
public:
	camera_demo(const glm::vec3 &pos		= default_cam_pos	, 
				const glm::vec3 &vec_front	= default_cam_front	, 
				const glm::vec3 &vec_up		= default_cam_up	, 
				const float &speed			= default_cam_speed	);
	~camera_demo();
	void move(const int &mode, const float &value);
	void look(const float &pitch_val, const float &yaw_val, const float &roll_val);
	void set(const int &mode, const float &value);
	void set(const int &mode, const glm::vec3 &vec);
	glm::mat4 view_mat();

private:
	glm::vec3 cam_up;
	glm::vec3 cam_front;
	glm::vec3 cam_pos;
	glm::mat4 view_matrix;
	float cam_speed;
	float cam_pitch;
	float cam_yaw;
	float cam_roll;
};


#endif // !_CAMERA_DEMO_H



